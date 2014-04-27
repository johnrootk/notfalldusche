////-- Warning.cs -- /////////////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Die Notfalldusche-Klasse, welche die Werte definiert, die jede Dusche hat//
// von Kevin Morgenthaler, Kjell Ita, Ramon Boss                            //
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
  public abstract class Notfalldusche
  {
    public static Random rand = new Random();
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
