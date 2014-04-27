using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ÜberwachungNotfalldusche;
using Simulation;
using System.Collections.Generic;

////-- HauptansichtTest.cs -- ////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Tests der publiken Funktionen der Hauptansicht                           //
// von Kevin Morgenthaler, Kjell Ita, Ramon Boss                            //
//////////////////////////////////////////////////////////////////////////////

namespace UnitTestNotfalldusche
{
  [TestClass]
  public class HauptansichtTest
  {
    [TestMethod]
    public void TestWarnings()
    {
      Hauptansicht appObject = new Hauptansicht();
      Simulator simulator = new Simulator();
      List<Notfalldusche> showers = simulator.getAllShowers();
      Notfalldusche shower1 = showers[0];
      Notfalldusche shower2 = showers[1];
      Warning expectedWarning = new Warning(shower1, Warning.Type.Flowrate);

      appObject.addWarning(new Warning(shower1, Warning.Type.Flowrate));

      // Test ob hasWarnings korrekt prüft ob eine Dusche bereits gewarnt hat
        // Gleiche Dusche
      Assert.AreEqual(true, appObject.hasWarnings(shower1));
        // Andere Dusche
      Assert.AreEqual(false, appObject.hasWarnings(shower2));
    }

    [TestMethod]
    public void TestSimulationStart()
    {
      Hauptansicht appObject = new Hauptansicht();
      // Test ob der Simulatorstart nicht null zurückgibt
      Assert.IsNotNull(appObject.startSimulator());
    }
  }
}