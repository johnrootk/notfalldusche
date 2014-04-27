////-- WarningComparer.cs -- /////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Dies ist eine Comparer-Klasse womit die Warnings aufgrund ihrer Aussage  //
// verglichen werden können.                                                //
// von Kevin Morgenthaler, Kjell Ita, Ramon Boss                            //
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ÜberwachungNotfalldusche
{
  class WarningComparer : IEqualityComparer<Warning>
  {
    /// <summary>
    /// Vergleicht 2 Warnings miteinander und gibt bool zurück ob sie gleich sind.
    /// </summary>
    /// <param name="a">Warning</param>
    /// <param name="b">Warning</param>
    /// <returns>bool ob gleich</returns>
    public bool Equals(Warning a, Warning b)
    {
      return a.isSameWarning(b);
    }

    public int GetHashCode(Warning a)
    {
      return a.GetHashCode();
    }
  }
}
