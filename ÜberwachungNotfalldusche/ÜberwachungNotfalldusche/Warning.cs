using Simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜberwachungNotfalldusche
{
  public class Warning
  {
    public enum Type
    {
      NotAvailable,
      Running,
      Flowrate,
      WaterPressure, 
      WaterTemperature,
      AmbientTemperature,
      TankLevel,
      TankTemperature,
      Lightsensor
    }

    public Notfalldusche shower;
    public Type type;
    public DateTime time;

    public Warning(Notfalldusche shower, Type type)
    {
      this.shower = shower;
      this.type = type;
      this.time = DateTime.Now;
    }

    public bool isSameWarning(Warning w)
    {
      return (w.shower == this.shower && w.type == this.type);
    }

    public string printWarning()
    {
      switch(type){
        case Type.NotAvailable:
          return "Verbindung verloren";
        case Type.Running:
          return "Die Dusche wird gerade benutzt";
        case Type.Flowrate:
          return "Flussrate ist ausserhalb der Norm";
        case Type.WaterPressure:
          return "Wasserdruck ist ausserhalb der Norm";
        case Type.WaterTemperature:
          return "Wassertemperatur ist ausserhalb der Norm";
        case Type.AmbientTemperature:
          return "Umgebungstemperatur ist ausserhalb der Norm";
        case Type.TankLevel:
          return "Der Wasserstand des Tanks ist zu gering";
        case Type.TankTemperature:
          return "Tankwassertemperatur ist ausserhalb der Norm";
        case Type.Lightsensor:
          return "Die Warnlampe leuchtet nicht mehr";
        default:
          return "";
      }
    }

    public override string ToString()
    {
      return time + "\t" + shower.name + "\t-\t" + printWarning();
    }
  }
}
