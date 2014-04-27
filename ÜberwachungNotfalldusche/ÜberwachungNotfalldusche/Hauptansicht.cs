////-- Hauptansicht.cs -- ////////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Hier werden alle Funktionen gelistet um die Hauptansicht zu verwalten    //
// von Kevin Morgenthaler, Kjell Ita, Ramon Boss                            //
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulation;
using System.Text.RegularExpressions;
using System.IO;

namespace ÜberwachungNotfalldusche
{
  public partial class Hauptansicht : Form
  {
    public Simulator schnittstelle;
    List<Warning> warnings;

    public Hauptansicht()
    {
      InitializeComponent();
      schnittstelle = startSimulator();
      warnings = new List<Warning>();
      refreshIntervall.Start();
      refreshShowerlist();
    }

    /// <summary>
    /// Hier wird die Simulator-Schnittstelle initialiisiert und angezeigt. 
    /// </summary>
    /// <returns>Schnittstellen-Referenz</returns>
    public Simulator startSimulator()
    {
      Simulator simulator = new Simulator();
      simulator.Show();
      return simulator;
    }

    /// <summary>
    /// Löscht alle Duschen aus der Liste und lädt die komplette Liste neu von der Schnittstelle.
    /// Anmerkung: 
    /// Rufe diese Funktion nicht regelmässig auf, da ein Refresh die Ansicht ganz nach oben stellt. 
    /// </summary>
    public void refreshShowerlist()
    {
      listview_showers.Items.Clear();
      foreach (Notfalldusche shower in schnittstelle.getAllShowers())
      {
        ListViewItem li = new ListViewItem(shower.name);
        li.Tag = shower;
        listview_showers.Items.Add(li);
      }
    }

    /// <summary>
    /// Kontrolliert die Werte der Notfallduschen und ruft gegebenenfalls addWarning() auf. 
    /// </summary>
    public void checkShowerstatus()
    {
      foreach (Notfalldusche shower in schnittstelle.getAllShowers())
      {
        if (!shower.testing)
        {
          // Hier werden die Normen definiert welche beim Abweichen eine Fehlermeldung werfen
          if (!shower.erreichbarkeit) addWarning(new Warning(shower, Warning.Type.NotAvailable));
          if (shower.schalterAugendusche || shower.schalterDusche) addWarning(new Warning(shower, Warning.Type.Running));
          if (shower.flussrate < 50 || shower.flussrate > 70) addWarning(new Warning(shower, Warning.Type.Flowrate));
          if (shower.wasserdruck < 0 || shower.wasserdruck > 20) addWarning(new Warning(shower, Warning.Type.WaterPressure));
          if (shower.wassertemperatur < 15 || shower.wassertemperatur > 30) addWarning(new Warning(shower, Warning.Type.WaterTemperature));
          if (shower is Duschkabine)
          {
            Duschkabine d = (Duschkabine)shower;
            if (d.umgebungstemperatur < -20 || d.umgebungstemperatur > 60) addWarning(new Warning(shower, Warning.Type.AmbientTemperature));
            if (d.wasserstand < 70 || d.wasserstand > 100) addWarning(new Warning(shower, Warning.Type.TankLevel));
            if (d.tankwassertemperatur < 15 || d.tankwassertemperatur > 30) addWarning(new Warning(shower, Warning.Type.TankTemperature));
            if (!d.lichtsensor) addWarning(new Warning(shower, Warning.Type.Lightsensor));
          }
        }
      }
    }

    /// <summary>
    /// Fügt die Warnung der Liste hinzu wenn sie neu ist. 
    /// </summary>
    /// <param name="warning">Reference to a warning</param>
    public void addWarning(Warning warning)
    {
      if (!warnings.Contains<Warning>(warning, new WarningComparer()))
      {
        warnings.Add(warning);
        lb_warninglist.Items.Add(warning);
        listview_showers.Refresh();
        writeLogEntry(warning.ToString());
      }
    }

    /// <summary>
    /// Returns bool if the shower already has an active warning
    /// </summary>
    /// <param name="shower"></param>
    /// <returns></returns>
    public bool hasWarnings(Notfalldusche shower)
    {
      foreach(Warning warning in warnings){
        if (warning.shower == shower) 
          return true;
      }
      return false;
    }

    /// <summary>
    /// Beim Quittieren wird die Warnung wieder aus der Liste entfernt.
    /// </summary>
    /// <param name="warning"></param>
    public void quitWarning(Warning warning)
    {
      if (warnings.Contains<Warning>(warning, new WarningComparer()))
      {
        lb_warninglist.Items.Remove(warning);
        warnings.Remove(warning);
        listview_showers.Refresh();
      }
    }

    /// <summary>
    /// Schreibt die Warnung in die Log-Datei. 
    /// </summary>
    /// <param name="log">string für den Logeintrag</param>
    private void writeLogEntry(string log)
    {
      if (!Directory.Exists("logs")) Directory.CreateDirectory("logs");
      using (StreamWriter file = new StreamWriter(@"logs\logfile.txt", true))
      {
        file.WriteLine(log);
      }
    }

    /// <summary>
    /// Zeigt die Detailansicht der Dusche in einem neuen Fenster an
    /// </summary>
    /// <param name="shower"></param>
    public void showDetail(Notfalldusche shower)
    {
      Detailansicht details = new Detailansicht(shower);
      details.Show();
    }

    /// <summary>
    /// Aufruf des Testes. Es wird der selbe Test aufgerufen ob für eine oder mehrere Duschen. 
    /// </summary>
    /// <param name="shower">Liste von Duschen</param>
    public void showShowerTest(List<Notfalldusche> showers)
    {
      Testansicht tests = new Testansicht(showers);
      tests.Show();
    }

    //////////////////////////////////////////////////////////////////////////////
    // Listener-Events                                                          //
    //////////////////////////////////////////////////////////////////////////////

    // Aufruf bei jedem Tick um die Duschen zu kontrollieren
    private void refreshIntervall_Tick(object sender, EventArgs e)
    {
      checkShowerstatus();
    }

    // Aktualisieren-Button um die Duschenliste neu zu laden
    private void btn_refresh_Click(object sender, EventArgs e)
    {
      refreshShowerlist();
    }

    // Funktion um die Duschsymbole selbst zu zeichnen. 
    // Dies erlaubt eine vollkommene Freiheit in der Gestaltung der Duschanzeige. 
    private void listview_showers_DrawItem(object sender, DrawListViewItemEventArgs e)
    {
      Notfalldusche dusche = (Notfalldusche)e.Item.Tag;
      SolidBrush forecolor = new SolidBrush(listview_showers.ForeColor);
      SolidBrush warnbrush = new SolidBrush(Color.Green);
      Image symbol = Properties.Resources.CheckSign;
      Pen pen = new Pen(Color.LightGray);
      Rectangle r = e.Bounds;
      int width = listview_showers.TileSize.Width;
      int height = listview_showers.TileSize.Height;
      int imgheight = height - 60;

      e.Graphics.DrawRectangle(pen, r);

      Image bild;
      if (dusche is Duschkabine) bild = ÜberwachungNotfalldusche.Properties.Resources.duschkabine;
      else bild = ÜberwachungNotfalldusche.Properties.Resources.standdusche;
      // Zentriert das Bild mittig und ändert die Grösse proportional
      e.Graphics.DrawImage(bild, r.X + (width - bild.Width * imgheight / bild.Height) / 2, r.Y, bild.Width * imgheight / bild.Height, imgheight);

      e.Graphics.DrawString(dusche.name, listview_showers.Font, new SolidBrush(listview_showers.ForeColor), r.X + 5, r.Y + 300);

      if (hasWarnings(dusche))
      {
        warnbrush = new SolidBrush(Color.Red);
        symbol = Properties.Resources.WarnSign;
      }
      e.Graphics.FillRectangle(warnbrush, r.X, r.Y + 318, width - 3, 40);
      e.Graphics.DrawImage(symbol, r.X + width / 2 - 18, r.Y + 322);
    }

    // Funktion zum Aufruf der Detailansicht pro Dusche
    private void listview_showers_MouseUp(object sender, MouseEventArgs e)
    {
      ListViewItem item = listview_showers.GetItemAt(e.X, e.Y);
      if (item != null)
      {
        Notfalldusche shower = (Notfalldusche)item.Tag;
        showDetail(shower);
      }
    }

    // Funktion des Aktualisieren-Buttons zum Quittieren der Warnungen
    private void btn_quit_Click(object sender, EventArgs e)
    {
      if(lb_warninglist.SelectedIndex >= 0) quitWarning((Warning)lb_warninglist.SelectedItem);
    }

    private void btn_testing_Click(object sender, EventArgs e)
    {
      showShowerTest(schnittstelle.getAllShowers());
    }

  }
}
