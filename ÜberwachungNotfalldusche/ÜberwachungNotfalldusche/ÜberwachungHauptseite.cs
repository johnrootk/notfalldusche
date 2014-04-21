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
    public partial class ÜberwachungHauptseite : Form
    {
        public Simulator schnittstelle;
        List<Notfalldusche> duschen;

        public ÜberwachungHauptseite()
        {
            InitializeComponent();
            schnittstelle = startSimulator();
            refreshIntervall.Start();
            zeigeDuschen();
        }

        /// <summary>
        /// Diese Funktion initialisiert die Simulator-Schnittstelle und zeigt diese an. 
        /// Gleichzeitig gibt sie die Verknüpfung dazu zurück
        /// </summary>
        /// <returns>Verknüpfung zur Schnittstelle</returns>
        public Simulator startSimulator(){
            Simulator simulator = new Simulator();
            simulator.Show();
            return simulator;
        }

        // Diese Funktion wird regelmässig neu aufgerufen und dient als Ausgangspunkt
        // zur Aktualisierung der ausgelesenen Werte und der Anzeige. 
        private void refreshIntervall_Tick(object sender, EventArgs e)
        {
            kontrolliereWerte();
        }

        /// <summary>
        /// Löscht alle Duschen aus der Liste und lädt die komplette Liste neu von der Schnittstelle.
        /// Diese Funktion wird nicht regelmässig aufgerufen, damit es die Schnittstelle nicht belastet
        /// und da ein Refresh die Markierung entfernt und die Ansicht ganz nach oben stellt. 
        /// </summary>
        public void zeigeDuschen()
        {
            duschen = schnittstelle.getAllShowers();
            listview_showers.Items.Clear();
            foreach(Notfalldusche dusche in duschen){
                ListViewItem li = new ListViewItem("Test");
                li.Tag = dusche;
                listview_showers.Items.Add(li);
            }

        }

        public void kontrolliereWerte()
        {
            foreach (Notfalldusche dusche in duschen)
            {
                // Hier werden die Normen definiert welche beim Abweichen eine Fehlermeldung werfen
                if (!dusche.erreichbarkeit) zeigeWarnung(dusche, 0);
                if (dusche.schalterAugendusche || dusche.schalterDusche) zeigeWarnung(dusche, 1);
                if (dusche.flussrate < 50 || dusche.flussrate > 70) zeigeWarnung(dusche, 2);
                if (dusche.wasserdruck < 0 || dusche.wasserdruck > 20) zeigeWarnung(dusche, 3);
                if (dusche.wassertemperatur < 15 || dusche.wassertemperatur > 30) zeigeWarnung(dusche, 4);
                if (dusche is Duschkabine)
                {
                    Duschkabine d = (Duschkabine)dusche;
                    if (d.umgebungstemperatur < -20 || d.umgebungstemperatur > 60) zeigeWarnung(d, 5);
                    if (d.wasserstand < 70 || d.wasserstand > 100) zeigeWarnung(d, 6);
                    if (d.tankwassertemperatur < 15 || d.tankwassertemperatur > 30) zeigeWarnung(d, 7);
                    if (!d.lichtsensor) zeigeWarnung(d, 8);
                }
 
            }
        }

        /// <summary>
        /// Zeigt je nach Fehlercode eine Meldung für den Benutzer an
        /// </summary>
        /// <param name="dusche"></param>
        /// <param name="fehlercode">0=Nicht erreichbar, 1=aktiv, 2=flussrate, 3=wasserdruck, 4=wassertemperatur, 5=umgebungstemp, 6=wasserstand, 7=tanktemp, 8=lichtsensor</param>
        public void zeigeWarnung(Notfalldusche dusche, int fehlercode)
        {
            string meldung = DateTime.Now + " " + dusche.name + "meldet:\n";
            switch (fehlercode)
            {
                case 0:
                    meldung += "Verbindung verloren";
                    break;
                case 1:
                    meldung += "Die Dusche wird gerade benutzt";
                    break;
                case 2:
                    meldung += "Flussrate ist ausserhalb der Norm ("+dusche.flussrate+"l/min)";
                    break;
                case 3:
                    meldung += "Wasserdruck ist ausserhalb der Norm ("+dusche.wasserdruck+")";
                    break;
                case 4:
                    meldung += "Wassertemperatur ist ausserhalb der Norm (" + dusche.wassertemperatur + "°C)";
                    break;
                case 5:
                    meldung += "Umgebungstemperatur ist ausserhalb der Norm ("+((Duschkabine)dusche).umgebungstemperatur+"°C)";
                    break;
                case 6:
                    meldung += "Der Wasserstand des Tanks ist zu gering (" + ((Duschkabine)dusche).wasserstand + "%)";
                    break;
                case 7:
                    meldung += "Tankwassertemperatur ist ausserhalb der Norm (" + ((Duschkabine)dusche).tankwassertemperatur + "°C)";
                    break;
                case 8:
                    meldung += "Die Warnlampe leuchtet nicht mehr";
                    break;
                default:
                    break;
            }

            // Schreibe einen Logeintrag

            // Zeigt nur dann ein Fenster wenn die Meldung kritisch ist. In den anderen Fällen, wird nur die Ansicht aktualisiert
            if (fehlercode == 1 || fehlercode == 6)
            {
                refreshIntervall.Stop();
                MessageBox.Show(meldung, "Warnung!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                refreshIntervall.Start();
            }
        }

        // Funktion des Aktualisieren-Buttons
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            zeigeDuschen();
        }

        // Funktion um die Duschsymbole selbst zu zeichnen. 
        // Dies erlaubt eine vollkommene Freiheit in der Gestaltung der Duschanzeige. 
        private void listview_showers_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Notfalldusche dusche = (Notfalldusche)e.Item.Tag;
            SolidBrush forecolor = new SolidBrush(listview_showers.ForeColor);
            Pen pen = new Pen(Color.LightGray);
            Rectangle r = e.Bounds;
            int width = listview_showers.TileSize.Width;
            int height = listview_showers.TileSize.Height;
            int imgheight = height - 100;

            e.Graphics.DrawRectangle(pen, r);

            Image bild;
            if (dusche is Duschkabine) bild = ÜberwachungNotfalldusche.Properties.Resources.duschkabine;
            else bild = ÜberwachungNotfalldusche.Properties.Resources.standdusche;
            // Zentriert das Bild mittig und ändert die Grösse proportional
            e.Graphics.DrawImage(bild, r.X + (width - bild.Width * imgheight / bild.Height) / 2, r.Y, bild.Width * imgheight / bild.Height, imgheight);
            e.Graphics.DrawString(dusche.name, listview_showers.Font, new SolidBrush(listview_showers.ForeColor), r.X+5, r.Y+300);
        }

        // Funktion zur Selektion des angeklickten Items
        private void listview_showers_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewItem clickedItem = listview_showers.GetItemAt(e.X, e.Y);
            if (clickedItem != null)
            {
                clickedItem.Selected = true;
                clickedItem.Focused = true;
                Detailansicht details = new Detailansicht((Notfalldusche)clickedItem.Tag);
                details.Show();
            }
        }

    }
}
