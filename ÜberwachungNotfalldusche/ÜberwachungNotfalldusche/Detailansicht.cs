using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulation;

namespace ÜberwachungNotfalldusche
{
  public partial class Detailansicht : Form
  {
    Notfalldusche shower;

    public Detailansicht(Notfalldusche shower)
    {
      InitializeComponent();
      this.shower = shower;
      initializeGUI();
      refreshTimer.Start();
    }

    /// <summary>
    /// Startet die ersten Werte welche nicht regelmässig aktualisiert werden und ruft 
    /// anschliessend die update-Funktion auf
    /// </summary>
    public void initializeGUI()
    {
      lbl_Name.Text = shower.name;
      pb_Image.Image = (shower is Duschkabine) ? ÜberwachungNotfalldusche.Properties.Resources.duschkabine : ÜberwachungNotfalldusche.Properties.Resources.standdusche;
      updateShowerstatus();
    }

    /// <summary>
    /// Aktualisiert alle Werte auf dem GUI welche sich regelmässig ändern können
    /// </summary>
    public void updateShowerstatus()
    {
      lbl_Wassertemperatur.Text = shower.wassertemperatur.ToString();
    }

    /// <summary>
    /// Aufruf des Testes. Es wird der selbe Test aufgerufen ob für eine oder mehrere Duschen. 
    /// </summary>
    /// <param name="shower">Liste von Duschen</param>
    public void showShowerTest()
    {
      Testansicht tests = new Testansicht(shower);
      tests.Show();
    }

    //////////////////////////////////////////////////////////////////////////////
    // Listener-Events                                                          //
    //////////////////////////////////////////////////////////////////////////////

    private void refreshTimer_Tick(object sender, EventArgs e)
    {
      updateShowerstatus();
    }

    private void btn_test_Click(object sender, EventArgs e)
    {
      showShowerTest();
    }
  }
}
