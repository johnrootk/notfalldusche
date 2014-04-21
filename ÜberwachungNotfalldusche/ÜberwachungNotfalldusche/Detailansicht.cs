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
        Notfalldusche dusche;

        public Detailansicht(Notfalldusche dusche)
        {
            InitializeComponent();
            this.dusche = dusche;
            zeigeWerte();
            refreshTimer.Start();
        }

        public void zeigeWerte(){
            lbl_Name.Text = dusche.name;
            pb_Image.Image = (dusche is Duschkabine) ? ÜberwachungNotfalldusche.Properties.Resources.duschkabine : ÜberwachungNotfalldusche.Properties.Resources.standdusche;
            aktualisiereWerte();
        }

        public void aktualisiereWerte()
        {
            lbl_Wassertemperatur.Text = dusche.wassertemperatur.ToString();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            aktualisiereWerte();
        }
    }
}
