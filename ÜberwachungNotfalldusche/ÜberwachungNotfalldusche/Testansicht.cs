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

    public Testansicht(Notfalldusche shower)
    {
      InitializeComponent();
      List<Notfalldusche> list = new List<Notfalldusche>();
      list.Add(shower);
      this.showers = list;
      addShowersToTest();
    }

    public Testansicht(List<Notfalldusche> showers)
    {
      InitializeComponent();
      this.showers = showers;
      addShowersToTest();
    }

    public void addShowersToTest(){
      accordion = addAccordion();
      foreach (Notfalldusche shower in showers)
      {
        addShowerExpander(shower);
      }
    }

    public Accordion addAccordion()
    {
      Accordion accordion = new Accordion();
      accordion.Size = new Size(400, 400);
      accordion.Dock = DockStyle.Top;
      pl_testing.Controls.Add(accordion);
      return accordion;
    }

    public void addShowerExpander(Notfalldusche shower){
      Expander expander = new Expander();
      expander.BorderStyle = BorderStyle.FixedSingle;
      expander.Tag = shower;
      ExpanderHelper.CreateLabelHeader(expander, shower.name, SystemColors.ActiveBorder);
      Chart chart = new Chart();
      chart.Size = new Size(400, 300);
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

    public void runTests()
    {
      Random rnd = new Random();
      foreach (Expander exp in accordion.Controls)
      {
        Notfalldusche shower = (Notfalldusche)exp.Tag;
        Chart c = (Chart)exp.Content;
        c.Series[0].Points.AddXY(0, 0);
        for (int i = 1; i <= 10; i++)
        {
          c.Series[0].Points.AddXY(i, 20);
          c.Series[1].Points.AddXY(i, rnd.Next(40, 70));
          c.Series[2].Points.AddXY(i, rnd.Next(20, 30));
        }
        c.Series[0].Points.AddXY(11, 0);
        exp.Header.Text = shower.name + " - DONE";
      }
    }

    private void testWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      runTests();
    }

    private void btn_runTest_Click(object sender, EventArgs e)
    {
      testWorker.RunWorkerAsync();
    }
  }
}
