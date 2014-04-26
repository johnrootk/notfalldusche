using Simulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ÜberwachungNotfalldusche
{
  public partial class Testansicht : Form
  {
    List<Notfalldusche> showers;
    Accordion accordion;

    /// <summary>
    /// Initialisierung einer einzelnen Dusche. 
    /// Dabei wird die Dusche in eine Liste aus einem einzelnen Element gepackt.
    /// </summary>
    /// <param name="shower">Dusche</param>
    public Testansicht(Notfalldusche shower)
    {
      InitializeComponent();
      List<Notfalldusche> list = new List<Notfalldusche>();
      list.Add(shower);
      this.showers = list;
      addShowersToTest();
    }

    /// <summary>
    /// Initialisierung einer Liste von Duschen
    /// </summary>
    /// <param name="showers">Liste der Duschen</param>
    public Testansicht(List<Notfalldusche> showers)
    {
      InitializeComponent();
      this.showers = showers;
      addShowersToTest();
    }

    /// <summary>
    /// Jede Dusche wird gelooped und die addShowerExpander wird dafür aufgerufen
    /// </summary>
    public void addShowersToTest(){
      accordion = addAccordion();
      foreach (Notfalldusche shower in showers)
      {
        addShowerExpander(shower);
      }
      pl_testing.AutoScrollMinSize = new Size(pl_testing.AutoScrollMinSize.Width, pl_testing.Height - 100 + showers.Count * 25);
    }

    /// <summary>
    /// Das Accordion-Control wird initialisiert und eingesetzt. 
    /// </summary>
    /// <returns>Das Accordion wird zurückgegeben</returns>
    public Accordion addAccordion()
    {
      Accordion accordion = new Accordion();
      accordion.Size = new Size(500, 500 - 100 + showers.Count * 25);
      accordion.Dock = DockStyle.Top;
      pl_testing.Controls.Add(accordion);
      return accordion;
    }

    /// <summary>
    /// Fügt jede Dusche einzeln als Expander zu einer Accordion-Ansicht hinzu. 
    /// Dabei wird auch gleich die Grafik initialisiert. 
    /// </summary>
    /// <param name="shower">Einzelne Dusche</param>
    public void addShowerExpander(Notfalldusche shower){
      Expander expander = new Expander();
      expander.BorderStyle = BorderStyle.FixedSingle;
      expander.Size = new Size(500, 400);
      expander.Tag = shower;
      ExpanderHelper.CreateLabelHeader(expander, shower.name, SystemColors.ActiveBorder);
      Chart chart = new Chart();
      chart.Size = new Size(500, 400);
      chart.Dock = DockStyle.Top;
      chart.ChartAreas.Add("Testing");
      chart.Legends.Add("Legende");
      chart.Series.Add(new Series("Aktivität"));
      chart.Series.Add(new Series("Flussrate"));
      chart.Series.Add(new Series("Temperatur"));
      chart.Series[0].ChartType = SeriesChartType.Range;
      chart.Series[1].ChartType = SeriesChartType.FastLine;
      chart.Series[2].ChartType = SeriesChartType.FastLine;
      chart.Series[0].ChartArea = "Testing";
      chart.Series[1].ChartArea = "Testing";
      chart.Series[2].ChartArea = "Testing";
      expander.Content = chart;
      accordion.Add(expander);
    }

    /// <summary>
    /// Durchläuft jede Dusche vom Test, lässt das Wasser für die Dusche und die
    /// Augendusche je 10 Sekunden laufen und prüft während dieses Zeitraums die
    /// Flussrate und die Temperatur
    /// </summary>
    public void runTests()
    {
      btn_runTest.Invoke((MethodInvoker)(() => btn_runTest.Enabled = false));
      foreach (Expander exp in accordion.Controls)
      {
        Notfalldusche shower = (Notfalldusche)exp.Tag;
        Chart c = (Chart)exp.Content;
        exp.Invoke((MethodInvoker)(() => exp.Expand()));
        if (!shower.schalterAugendusche && !shower.schalterDusche)
        {
          shower.testing = true;
          c.Invoke((MethodInvoker)(() => c.Series[0].Points.AddXY(0, 0)));
          shower.schalterAugendusche = true;
          for (int i = 1; i <= 10; i++)
          {
            c.Invoke((MethodInvoker)(() => c.Series[0].Points.AddXY(i, 20)));
            c.Invoke((MethodInvoker)(() => c.Series[1].Points.AddXY(i, shower.flussrate)));
            c.Invoke((MethodInvoker)(() => c.Series[2].Points.AddXY(i, shower.wassertemperatur)));
            Thread.Sleep(1000);
          }
          shower.schalterAugendusche = false;
          c.Invoke((MethodInvoker)(() => c.Series[0].Points.AddXY(11, 0)));
          shower.schalterDusche = true;
          for (int i = 12; i <= 21; i++)
          {
            c.Invoke((MethodInvoker)(() => c.Series[0].Points.AddXY(i, 20)));
            c.Invoke((MethodInvoker)(() => c.Series[1].Points.AddXY(i, shower.flussrate)));
            c.Invoke((MethodInvoker)(() => c.Series[2].Points.AddXY(i, shower.wassertemperatur)));
            Thread.Sleep(1000);
          }
          shower.schalterDusche = false;
          c.Invoke((MethodInvoker)(() => c.Series[0].Points.AddXY(22, 0)));
          exp.Invoke((MethodInvoker)(() => exp.Header.Text = shower.name + " - Erfolgreich beendet"));
          shower.testing = false;
        }
        else
        {
          exp.Invoke((MethodInvoker)(() => exp.Header.Text = shower.name + " - Dusche wird benutzt"));
        }
      }
      btn_runTest.Invoke((MethodInvoker)(() => btn_runTest.Enabled = true));
    }

    //////////////////////////////////////////////////////////////////////////////
    // Listener-Events                                                          //
    //////////////////////////////////////////////////////////////////////////////

    // Funktion welche aufgerufen werden sobald der Background-Worker gestartet wird.
    private void testWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      runTests();
    }

    // Funktion die beim Drücken des Test-Buttons aktiviert werden.
    private void btn_runTest_Click(object sender, EventArgs e)
    {
      testWorker.RunWorkerAsync();
    }

  }
}
