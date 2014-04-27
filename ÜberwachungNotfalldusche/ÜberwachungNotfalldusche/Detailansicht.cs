////-- Detailansicht.cs -- ///////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Hier werden alle Funktionen gelistet um die Detailansicht zu verwalten   //
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

namespace ÜberwachungNotfalldusche
{
  public partial class Detailansicht : Form
  {
    Notfalldusche shower;

    public Detailansicht(Notfalldusche shower)
    {
      InitializeComponent();
      this.shower = shower;
      initializeGUI();
      refreshTimer.Start();
    }

    /// <summary>
    /// Startet die ersten Werte welche nicht regelmässig aktualisiert werden und ruft 
    /// anschliessend die update-Funktion auf
    /// </summary>
    public void initializeGUI()
    {
      lbl_Name.Text = shower.name;
      pb_Image.Image = (shower is Duschkabine) ? ÜberwachungNotfalldusche.Properties.Resources.duschkabine : ÜberwachungNotfalldusche.Properties.Resources.standdusche;
      updateShowerstatus();
      if (!(shower is Duschkabine))
      {
        lbl_wasserstand.Visible = false;
        val_tankwasserstand.Visible = false;
        lbl_Tankwassertemp.Visible = false;
        val_tankwassertemp.Visible = false;
        lbl_umgebungstemperatur.Visible = false;
        val_umgebungstemperatur.Visible = false;
        lbl_lichtsensor.Visible = false;
      }
    }

    /// <summary>
    /// Aktualisiert alle Werte auf dem GUI welche sich regelmässig ändern können
    /// </summary>
    public void updateShowerstatus()
    {
      val_flussrate.Text = shower.flussrate.ToString() + " l/min";
      val_wasserdruck.Text = shower.wasserdruck.ToString() + " P";
      val_wassertemperatur.Text = shower.wassertemperatur.ToString() + " °C";
      lbl_erreichbarkeit.Enabled = shower.erreichbarkeit;
      lbl_schalteraugen.Enabled = shower.schalterAugendusche;
      lbl_schalterdusche.Enabled = shower.schalterDusche;
      if (shower is Duschkabine)
      {
        Duschkabine kab = (Duschkabine)shower;
        val_tankwasserstand.Text = kab.wasserstand.ToString() + " %";
        val_tankwassertemp.Text = kab.tankwassertemperatur.ToString() + " °C";
        val_umgebungstemperatur.Text = kab.umgebungstemperatur.ToString() + " °C";
        lbl_lichtsensor.Enabled = kab.lichtsensor;
      }
    }

    /// <summary>
    /// Aufruf des Testes. Es wird der selbe Test aufgerufen ob für eine oder mehrere Duschen. 
    /// </summary>
    /// <param name="shower">Liste von Duschen</param>
    public void showShowerTest()
    {
      Testansicht tests = new Testansicht(shower);
      tests.Show();
    }

    //////////////////////////////////////////////////////////////////////////////
    // Listener-Events                                                          //
    //////////////////////////////////////////////////////////////////////////////

    private void refreshTimer_Tick(object sender, EventArgs e)
    {
      updateShowerstatus();
    }

    private void btn_test_Click(object sender, EventArgs e)
    {
      showShowerTest();
    }
  }
}
