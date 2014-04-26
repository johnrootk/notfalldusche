using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ÜberwachungNotfalldusche
{
  class WarningComparer : IEqualityComparer<Warning>
  {
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
