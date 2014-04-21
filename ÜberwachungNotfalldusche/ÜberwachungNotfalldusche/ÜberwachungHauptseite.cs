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

        public ÜberwachungHauptseite()
        {
            InitializeComponent();
            schnittstelle = startSimulator();
            refreshIntervall.Start();
        }

        public Simulator startSimulator(){
            Simulator simulator = new Simulator();
            simulator.Show();
            return simulator;
        }

        private void refreshIntervall_Tick(object sender, EventArgs e)
        {

        }

        public void zeigeDuschen()
        {
            List<Notfalldusche> duschen = schnittstelle.getAllShowers();
            
        }
    }
}
