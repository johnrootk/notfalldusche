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
    public bool schalterAugendusche;
    public bool schalterDusche;

    public bool erreichbarkeit;

    public bool testing;

    public Notfalldusche()
    {
      rand = new Random();
      flussrate = 60;
      wasserdruck = 2;
      wassertemperatur = 20;
      schalterAugendusche = false;
      schalterDusche = false;
      erreichbarkeit = true;

      testing = false;
    }

    public override string ToString()
    {
      return name;
    }
  }
}