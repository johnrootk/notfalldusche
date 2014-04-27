////-- Warning.cs -- /////////////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Die speziellen Werte der Standdusche (Erbt von Notfalldusche)            //
// von Kevin Morgenthaler, Kjell Ita, Ramon Boss                            //
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
  public class Standdusche : Notfalldusche
  {
    public Standdusche()
      : base()
    {
      name = "Standdusche" + rand.Next(1000, 9999);
    }
  }
}
