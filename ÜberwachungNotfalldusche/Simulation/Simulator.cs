using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation
{
    public partial class Simulator : Form
    {
        public List<Notfalldusche> notfallduschen;
        Notfalldusche selektion;

        public Simulator()
        {
            InitializeComponent();
            notfallduschen = new List<Notfalldusche>();
        }

        public List<Notfalldusche> getAllShowers()
        {
            return notfallduschen;
        }

        private void btn_standdusche_Click(object sender, EventArgs e)
        {
            notfallduschen.Add(new Standdusche());
            aktualisiereDuschenliste();
        }

        private void btn_duschkabine_Click(object sender, EventArgs e)
        {
            notfallduschen.Add(new Duschkabine());
            aktualisiereDuschenliste();
        }

        private void btn_duschelöschen_Click(object sender, EventArgs e)
        {
            notfallduschen.Remove((Notfalldusche)lb_duschenliste.SelectedItem);
            aktualisiereDuschenliste();
            lb_duschenliste.SelectedIndex = -1;
            pl_einstellungen.Visible = false;
        }

        private void aktualisiereDuschenliste(){
            lb_duschenliste.Items.Clear();
            lb_duschenliste.Items.AddRange(notfallduschen.ToArray());
        }

        private void lb_duschenliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_duschenliste.SelectedIndex > -1)
            {
                pl_einstellungen.Visible = true;

                selektion = (Notfalldusche)lb_duschenliste.SelectedItem;

                barFlussrate.Value = (int)selektion.flussrate;
                showFlussrate.Text = barFlussrate.Value.ToString();
                barWasserdruck.Value = (int)selektion.wasserdruck;
                showWasserdruck.Text = barWasserdruck.Value.ToString();
                barWassertemperatur.Value = (int)selektion.wassertemperatur;
                showWassertemperatur.Text = barWassertemperatur.Value.ToString();
                ckAugendusche.Checked = selektion.schalterAugendusche;
                ckGanzkörperdusche.Checked = selektion.schalterDusche;

                if (selektion is Duschkabine)
                {
                    barUmgebungstemperatur.Value = (int)((Duschkabine)selektion).umgebungstemperatur;
                    showUmgebungstemperatur.Text = barUmgebungstemperatur.Value.ToString();
                    barWasserstand.Value = (int)((Duschkabine)selektion).wasserstand;
                    showWasserstand.Text = barWasserstand.Value.ToString();
                    barTankwassertemperatur.Value = (int)((Duschkabine)selektion).tankwassertemperatur;
                    showTankwassertemperatur.Text = barTankwassertemperatur.Value.ToString();
                    ckLichtsensor.Checked = ((Duschkabine)selektion).lichtsensor;

                    pl_Umgebungstemperatur.Visible = true;
                    pl_Wasserstand.Visible = true;
                    pl_Tankwassertemperatur.Visible = true;
                    pl_Lichtsensor.Visible = true;
                }
                else
                {
                    pl_Umgebungstemperatur.Visible = false;
                    pl_Wasserstand.Visible = false;
                    pl_Tankwassertemperatur.Visible = false;
                    pl_Lichtsensor.Visible = false;
                }
            }
            else
            {
                pl_einstellungen.Visible = false;
            }
        }

        private void barFlussrate_Scroll(object sender, EventArgs e)
        {
            showFlussrate.Text = barFlussrate.Value.ToString();
            selektion.flussrate = barFlussrate.Value;
        }

        private void barWasserdruck_Scroll(object sender, EventArgs e)
        {
            showWasserdruck.Text = barWasserdruck.Value.ToString();
            selektion.wasserdruck = barWasserdruck.Value;
        }

        private void barWassertemperatur_Scroll(object sender, EventArgs e)
        {
            showWassertemperatur.Text = barWassertemperatur.Value.ToString();
            selektion.wassertemperatur = barWassertemperatur.Value;
        }

        private void barUmgebungstemperatur_Scroll(object sender, EventArgs e)
        {
            showUmgebungstemperatur.Text = barUmgebungstemperatur.Value.ToString();
            ((Duschkabine)selektion).umgebungstemperatur = barUmgebungstemperatur.Value;
        }

        private void barWasserstand_Scroll(object sender, EventArgs e)
        {
            showWasserstand.Text = barWasserstand.Value.ToString();
            ((Duschkabine)selektion).wasserstand = barWasserstand.Value;
        }

        private void barTankwassertemperatur_Scroll(object sender, EventArgs e)
        {
            showTankwassertemperatur.Text = barTankwassertemperatur.Value.ToString();
            ((Duschkabine)selektion).tankwassertemperatur = barTankwassertemperatur.Value;
        }

        private void ckAugendusche_CheckedChanged(object sender, EventArgs e)
        {
            selektion.schalterAugendusche = ckAugendusche.Checked;
        }

        private void ckGanzkörperdusche_CheckedChanged(object sender, EventArgs e)
        {
            selektion.schalterDusche = ckGanzkörperdusche.Checked;
        }

        private void ckLichtsensor_CheckedChanged(object sender, EventArgs e)
        {
            ((Duschkabine)selektion).lichtsensor = ckLichtsensor.Checked;
        }

    }
}
