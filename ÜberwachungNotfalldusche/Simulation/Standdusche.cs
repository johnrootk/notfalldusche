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
