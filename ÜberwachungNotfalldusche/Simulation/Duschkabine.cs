using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public class Duschkabine : Notfalldusche
    {
        public double umgebungstemperatur;
        public double wasserstand;
        public double tankwassertemperatur;
        public Boolean lichtsensor;

        public Duschkabine() : base()
        {
            umgebungstemperatur = 25;
            wasserstand = 80;
            tankwassertemperatur = 18;
            lichtsensor = true;
            name = "Duschkabine" + rand.Next(1000, 9999);
        }
    }
}
