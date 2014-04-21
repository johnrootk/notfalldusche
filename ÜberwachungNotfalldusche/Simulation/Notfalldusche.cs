using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public abstract class Notfalldusche
    {
        public Random rand;
        public string name;
        public double flussrate;
        public double wasserdruck;
        public double wassertemperatur;
        public Boolean schalterAugendusche;
        public Boolean schalterDusche;

        public Boolean erreichbarkeit;

        public Notfalldusche()
        {
            rand = new Random();
            flussrate = 60;
            wasserdruck = 2;
            wassertemperatur = 20;
            schalterAugendusche = false;
            schalterDusche = false;
            erreichbarkeit = true;
        }

        public override string ToString()
        {
            return name;
        }
    }
}