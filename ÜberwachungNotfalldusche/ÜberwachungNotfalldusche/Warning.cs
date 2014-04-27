////-- Warning.cs -- /////////////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Diese Klasse definiert das Warning-Objekt mit seinen Werten              //
// von Kevin Morgenthaler, Kjell Ita, Ramon Boss                            //
//////////////////////////////////////////////////////////////////////////////

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

    /// <summary>
    /// Vergleich zweier Warnungen aufgrund des Types und der Dusche
    /// </summary>
    /// <param name="w">zweite Warnung</param>
    /// <returns>bool ob sie gleich sind</returns>
    public bool isSameWarning(Warning w)
    {
      return (w.shower == this.shower && w.type == this.type);
    }

    /// <summary>
    /// Gibt einen String zurück besierend auf dem Typ der Warnung
    /// </summary>
    /// <returns>string der Warnung</returns>
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

    /// <summary>
    /// Überschreibung der ToString-Methode um eine Warnung als string auszugeben
    /// </summary>
    /// <returns>string der gesamten Warnung</returns>
    public override string ToString()
    {
      return time + "\t" + shower.name + "\t-\t" + printWarning();
    }
  }
}
