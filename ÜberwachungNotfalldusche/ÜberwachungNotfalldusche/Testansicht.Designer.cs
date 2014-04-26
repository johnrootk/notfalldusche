namespace ÜberwachungNotfalldusche
{
  partial class Testansicht
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pl_testing = new System.Windows.Forms.Panel();
      this.testWorker = new System.ComponentModel.BackgroundWorker();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_runTest = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pl_testing
      // 
      this.pl_testing.AutoScroll = true;
      this.pl_testing.AutoScrollMinSize = new System.Drawing.Size(300, 501);
      this.pl_testing.AutoSize = true;
      this.pl_testing.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pl_testing.Location = new System.Drawing.Point(0, 0);
      this.pl_testing.Name = "pl_testing";
      this.pl_testing.Size = new System.Drawing.Size(680, 501);
      this.pl_testing.TabIndex = 0;
      // 
      // testWorker
      // 
      this.testWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.testWorker_DoWork);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_runTest);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(680, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(138, 501);
      this.panel1.TabIndex = 0;
      // 
      // btn_runTest
      // 
      this.btn_runTest.Location = new System.Drawing.Point(28, 25);
      this.btn_runTest.Name = "btn_runTest";
      this.btn_runTest.Size = new System.Drawing.Size(84, 23);
      this.btn_runTest.TabIndex = 0;
      this.btn_runTest.Text = "Tests starten";
      this.btn_runTest.UseVisualStyleBackColor = true;
      this.btn_runTest.Click += new System.EventHandler(this.btn_runTest_Click);
      // 
      // Testansicht
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(818, 501);
      this.Controls.Add(this.pl_testing);
      this.Controls.Add(this.panel1);
      this.Name = "Testansicht";
      this.Text = "Testansicht";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pl_testing;
    private System.ComponentModel.BackgroundWorker testWorker;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_runTest;



  }
}