namespace Simulation
{
    partial class Simulator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_duschenliste = new System.Windows.Forms.ListBox();
            this.btn_standdusche = new System.Windows.Forms.Button();
            this.btn_duschkabine = new System.Windows.Forms.Button();
            this.btn_duschelöschen = new System.Windows.Forms.Button();
            this.barFlussrate = new System.Windows.Forms.TrackBar();
            this.lbl_flussrate = new System.Windows.Forms.Label();
            this.pl_Flussrate = new System.Windows.Forms.Panel();
            this.pl_Wasserdruck = new System.Windows.Forms.Panel();
            this.barWasserdruck = new System.Windows.Forms.TrackBar();
            this.lbl_Wasserdruck = new System.Windows.Forms.Label();
            this.pl_Wassertemperatur = new System.Windows.Forms.Panel();
            this.barWassertemperatur = new System.Windows.Forms.TrackBar();
            this.lbl_Wassertemperatur = new System.Windows.Forms.Label();
            this.pl_Umgebungstemperatur = new System.Windows.Forms.Panel();
            this.barUmgebungstemperatur = new System.Windows.Forms.TrackBar();
            this.lbl_Umgebungstemperatur = new System.Windows.Forms.Label();
            this.pl_Wasserstand = new System.Windows.Forms.Panel();
            this.barWasserstand = new System.Windows.Forms.TrackBar();
            this.lbl_Wasserstand = new System.Windows.Forms.Label();
            this.pl_Tankwassertemperatur = new System.Windows.Forms.Panel();
            this.barTankwassertemperatur = new System.Windows.Forms.TrackBar();
            this.lbl_Tankwassertemperatur = new System.Windows.Forms.Label();
            this.pl_Lichtsensor = new System.Windows.Forms.Panel();
            this.lbl_Lichtsensor = new System.Windows.Forms.Label();
            this.ckLichtsensor = new System.Windows.Forms.CheckBox();
            this.pl_Augendusche = new System.Windows.Forms.Panel();
            this.ckAugendusche = new System.Windows.Forms.CheckBox();
            this.lbl_Augendusche = new System.Windows.Forms.Label();
            this.pl_Ganzkörperdusche = new System.Windows.Forms.Panel();
            this.ckGanzkörperdusche = new System.Windows.Forms.CheckBox();
            this.lbl_Ganzkörperdusche = new System.Windows.Forms.Label();
            this.showFlussrate = new System.Windows.Forms.Label();
            this.showWasserdruck = new System.Windows.Forms.Label();
            this.showWassertemperatur = new System.Windows.Forms.Label();
            this.showUmgebungstemperatur = new System.Windows.Forms.Label();
            this.showWasserstand = new System.Windows.Forms.Label();
            this.showTankwassertemperatur = new System.Windows.Forms.Label();
            this.pl_einstellungen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.barFlussrate)).BeginInit();
            this.pl_Flussrate.SuspendLayout();
            this.pl_Wasserdruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWasserdruck)).BeginInit();
            this.pl_Wassertemperatur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWassertemperatur)).BeginInit();
            this.pl_Umgebungstemperatur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barUmgebungstemperatur)).BeginInit();
            this.pl_Wasserstand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWasserstand)).BeginInit();
            this.pl_Tankwassertemperatur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barTankwassertemperatur)).BeginInit();
            this.pl_Lichtsensor.SuspendLayout();
            this.pl_Augendusche.SuspendLayout();
            this.pl_Ganzkörperdusche.SuspendLayout();
            this.pl_einstellungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_duschenliste
            // 
            this.lb_duschenliste.FormattingEnabled = true;
            this.lb_duschenliste.Location = new System.Drawing.Point(12, 12);
            this.lb_duschenliste.Name = "lb_duschenliste";
            this.lb_duschenliste.Size = new System.Drawing.Size(158, 407);
            this.lb_duschenliste.TabIndex = 0;
            this.lb_duschenliste.SelectedIndexChanged += new System.EventHandler(this.lb_duschenliste_SelectedIndexChanged);
            // 
            // btn_standdusche
            // 
            this.btn_standdusche.Location = new System.Drawing.Point(176, 12);
            this.btn_standdusche.Name = "btn_standdusche";
            this.btn_standdusche.Size = new System.Drawing.Size(109, 23);
            this.btn_standdusche.TabIndex = 1;
            this.btn_standdusche.Text = "Neue Standdusche";
            this.btn_standdusche.UseVisualStyleBackColor = true;
            this.btn_standdusche.Click += new System.EventHandler(this.btn_standdusche_Click);
            // 
            // btn_duschkabine
            // 
            this.btn_duschkabine.Location = new System.Drawing.Point(176, 41);
            this.btn_duschkabine.Name = "btn_duschkabine";
            this.btn_duschkabine.Size = new System.Drawing.Size(109, 23);
            this.btn_duschkabine.TabIndex = 2;
            this.btn_duschkabine.Text = "Neue Duschkabine";
            this.btn_duschkabine.UseVisualStyleBackColor = true;
            this.btn_duschkabine.Click += new System.EventHandler(this.btn_duschkabine_Click);
            // 
            // btn_duschelöschen
            // 
            this.btn_duschelöschen.Location = new System.Drawing.Point(176, 396);
            this.btn_duschelöschen.Name = "btn_duschelöschen";
            this.btn_duschelöschen.Size = new System.Drawing.Size(109, 23);
            this.btn_duschelöschen.TabIndex = 3;
            this.btn_duschelöschen.Text = "Auswahl löschen";
            this.btn_duschelöschen.UseVisualStyleBackColor = true;
            this.btn_duschelöschen.Click += new System.EventHandler(this.btn_duschelöschen_Click);
            // 
            // barFlussrate
            // 
            this.barFlussrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barFlussrate.Location = new System.Drawing.Point(0, 13);
            this.barFlussrate.Maximum = 100;
            this.barFlussrate.Name = "barFlussrate";
            this.barFlussrate.Size = new System.Drawing.Size(327, 25);
            this.barFlussrate.TabIndex = 4;
            this.barFlussrate.Scroll += new System.EventHandler(this.barFlussrate_Scroll);
            // 
            // lbl_flussrate
            // 
            this.lbl_flussrate.AutoSize = true;
            this.lbl_flussrate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_flussrate.Location = new System.Drawing.Point(0, 0);
            this.lbl_flussrate.Name = "lbl_flussrate";
            this.lbl_flussrate.Size = new System.Drawing.Size(49, 13);
            this.lbl_flussrate.TabIndex = 5;
            this.lbl_flussrate.Text = "Flussrate";
            // 
            // pl_Flussrate
            // 
            this.pl_Flussrate.Controls.Add(this.barFlussrate);
            this.pl_Flussrate.Controls.Add(this.lbl_flussrate);
            this.pl_Flussrate.Controls.Add(this.showFlussrate);
            this.pl_Flussrate.Location = new System.Drawing.Point(3, 3);
            this.pl_Flussrate.Name = "pl_Flussrate";
            this.pl_Flussrate.Size = new System.Drawing.Size(373, 38);
            this.pl_Flussrate.TabIndex = 6;
            // 
            // pl_Wasserdruck
            // 
            this.pl_Wasserdruck.Controls.Add(this.barWasserdruck);
            this.pl_Wasserdruck.Controls.Add(this.lbl_Wasserdruck);
            this.pl_Wasserdruck.Controls.Add(this.showWasserdruck);
            this.pl_Wasserdruck.Location = new System.Drawing.Point(3, 47);
            this.pl_Wasserdruck.Name = "pl_Wasserdruck";
            this.pl_Wasserdruck.Size = new System.Drawing.Size(373, 38);
            this.pl_Wasserdruck.TabIndex = 7;
            // 
            // barWasserdruck
            // 
            this.barWasserdruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barWasserdruck.Location = new System.Drawing.Point(0, 13);
            this.barWasserdruck.Maximum = 1000;
            this.barWasserdruck.Name = "barWasserdruck";
            this.barWasserdruck.Size = new System.Drawing.Size(327, 25);
            this.barWasserdruck.TabIndex = 4;
            this.barWasserdruck.Scroll += new System.EventHandler(this.barWasserdruck_Scroll);
            // 
            // lbl_Wasserdruck
            // 
            this.lbl_Wasserdruck.AutoSize = true;
            this.lbl_Wasserdruck.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Wasserdruck.Location = new System.Drawing.Point(0, 0);
            this.lbl_Wasserdruck.Name = "lbl_Wasserdruck";
            this.lbl_Wasserdruck.Size = new System.Drawing.Size(70, 13);
            this.lbl_Wasserdruck.TabIndex = 5;
            this.lbl_Wasserdruck.Text = "Wasserdruck";
            // 
            // pl_Wassertemperatur
            // 
            this.pl_Wassertemperatur.Controls.Add(this.barWassertemperatur);
            this.pl_Wassertemperatur.Controls.Add(this.lbl_Wassertemperatur);
            this.pl_Wassertemperatur.Controls.Add(this.showWassertemperatur);
            this.pl_Wassertemperatur.Location = new System.Drawing.Point(3, 91);
            this.pl_Wassertemperatur.Name = "pl_Wassertemperatur";
            this.pl_Wassertemperatur.Size = new System.Drawing.Size(373, 38);
            this.pl_Wassertemperatur.TabIndex = 8;
            // 
            // barWassertemperatur
            // 
            this.barWassertemperatur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barWassertemperatur.Location = new System.Drawing.Point(0, 13);
            this.barWassertemperatur.Maximum = 100;
            this.barWassertemperatur.Minimum = -30;
            this.barWassertemperatur.Name = "barWassertemperatur";
            this.barWassertemperatur.Size = new System.Drawing.Size(327, 25);
            this.barWassertemperatur.TabIndex = 4;
            this.barWassertemperatur.Scroll += new System.EventHandler(this.barWassertemperatur_Scroll);
            // 
            // lbl_Wassertemperatur
            // 
            this.lbl_Wassertemperatur.AutoSize = true;
            this.lbl_Wassertemperatur.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Wassertemperatur.Location = new System.Drawing.Point(0, 0);
            this.lbl_Wassertemperatur.Name = "lbl_Wassertemperatur";
            this.lbl_Wassertemperatur.Size = new System.Drawing.Size(93, 13);
            this.lbl_Wassertemperatur.TabIndex = 5;
            this.lbl_Wassertemperatur.Text = "Wassertemperatur";
            // 
            // pl_Umgebungstemperatur
            // 
            this.pl_Umgebungstemperatur.Controls.Add(this.barUmgebungstemperatur);
            this.pl_Umgebungstemperatur.Controls.Add(this.lbl_Umgebungstemperatur);
            this.pl_Umgebungstemperatur.Controls.Add(this.showUmgebungstemperatur);
            this.pl_Umgebungstemperatur.Location = new System.Drawing.Point(3, 242);
            this.pl_Umgebungstemperatur.Name = "pl_Umgebungstemperatur";
            this.pl_Umgebungstemperatur.Size = new System.Drawing.Size(373, 38);
            this.pl_Umgebungstemperatur.TabIndex = 9;
            // 
            // barUmgebungstemperatur
            // 
            this.barUmgebungstemperatur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barUmgebungstemperatur.Location = new System.Drawing.Point(0, 13);
            this.barUmgebungstemperatur.Maximum = 100;
            this.barUmgebungstemperatur.Minimum = -30;
            this.barUmgebungstemperatur.Name = "barUmgebungstemperatur";
            this.barUmgebungstemperatur.Size = new System.Drawing.Size(327, 25);
            this.barUmgebungstemperatur.TabIndex = 4;
            this.barUmgebungstemperatur.Scroll += new System.EventHandler(this.barUmgebungstemperatur_Scroll);
            // 
            // lbl_Umgebungstemperatur
            // 
            this.lbl_Umgebungstemperatur.AutoSize = true;
            this.lbl_Umgebungstemperatur.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Umgebungstemperatur.Location = new System.Drawing.Point(0, 0);
            this.lbl_Umgebungstemperatur.Name = "lbl_Umgebungstemperatur";
            this.lbl_Umgebungstemperatur.Size = new System.Drawing.Size(114, 13);
            this.lbl_Umgebungstemperatur.TabIndex = 5;
            this.lbl_Umgebungstemperatur.Text = "Umgebungstemperatur";
            // 
            // pl_Wasserstand
            // 
            this.pl_Wasserstand.Controls.Add(this.barWasserstand);
            this.pl_Wasserstand.Controls.Add(this.lbl_Wasserstand);
            this.pl_Wasserstand.Controls.Add(this.showWasserstand);
            this.pl_Wasserstand.Location = new System.Drawing.Point(3, 286);
            this.pl_Wasserstand.Name = "pl_Wasserstand";
            this.pl_Wasserstand.Size = new System.Drawing.Size(373, 38);
            this.pl_Wasserstand.TabIndex = 10;
            // 
            // barWasserstand
            // 
            this.barWasserstand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barWasserstand.Location = new System.Drawing.Point(0, 13);
            this.barWasserstand.Maximum = 100;
            this.barWasserstand.Name = "barWasserstand";
            this.barWasserstand.Size = new System.Drawing.Size(327, 25);
            this.barWasserstand.TabIndex = 4;
            this.barWasserstand.Scroll += new System.EventHandler(this.barWasserstand_Scroll);
            // 
            // lbl_Wasserstand
            // 
            this.lbl_Wasserstand.AutoSize = true;
            this.lbl_Wasserstand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Wasserstand.Location = new System.Drawing.Point(0, 0);
            this.lbl_Wasserstand.Name = "lbl_Wasserstand";
            this.lbl_Wasserstand.Size = new System.Drawing.Size(69, 13);
            this.lbl_Wasserstand.TabIndex = 5;
            this.lbl_Wasserstand.Text = "Wasserstand";
            // 
            // pl_Tankwassertemperatur
            // 
            this.pl_Tankwassertemperatur.Controls.Add(this.barTankwassertemperatur);
            this.pl_Tankwassertemperatur.Controls.Add(this.lbl_Tankwassertemperatur);
            this.pl_Tankwassertemperatur.Controls.Add(this.showTankwassertemperatur);
            this.pl_Tankwassertemperatur.Location = new System.Drawing.Point(3, 330);
            this.pl_Tankwassertemperatur.Name = "pl_Tankwassertemperatur";
            this.pl_Tankwassertemperatur.Size = new System.Drawing.Size(373, 38);
            this.pl_Tankwassertemperatur.TabIndex = 11;
            // 
            // barTankwassertemperatur
            // 
            this.barTankwassertemperatur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barTankwassertemperatur.Location = new System.Drawing.Point(0, 13);
            this.barTankwassertemperatur.Maximum = 100;
            this.barTankwassertemperatur.Minimum = -30;
            this.barTankwassertemperatur.Name = "barTankwassertemperatur";
            this.barTankwassertemperatur.Size = new System.Drawing.Size(327, 25);
            this.barTankwassertemperatur.TabIndex = 4;
            this.barTankwassertemperatur.Scroll += new System.EventHandler(this.barTankwassertemperatur_Scroll);
            // 
            // lbl_Tankwassertemperatur
            // 
            this.lbl_Tankwassertemperatur.AutoSize = true;
            this.lbl_Tankwassertemperatur.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Tankwassertemperatur.Location = new System.Drawing.Point(0, 0);
            this.lbl_Tankwassertemperatur.Name = "lbl_Tankwassertemperatur";
            this.lbl_Tankwassertemperatur.Size = new System.Drawing.Size(115, 13);
            this.lbl_Tankwassertemperatur.TabIndex = 5;
            this.lbl_Tankwassertemperatur.Text = "Tankwassertemperatur";
            // 
            // pl_Lichtsensor
            // 
            this.pl_Lichtsensor.Controls.Add(this.ckLichtsensor);
            this.pl_Lichtsensor.Controls.Add(this.lbl_Lichtsensor);
            this.pl_Lichtsensor.Location = new System.Drawing.Point(3, 374);
            this.pl_Lichtsensor.Name = "pl_Lichtsensor";
            this.pl_Lichtsensor.Size = new System.Drawing.Size(172, 38);
            this.pl_Lichtsensor.TabIndex = 12;
            // 
            // lbl_Lichtsensor
            // 
            this.lbl_Lichtsensor.AutoSize = true;
            this.lbl_Lichtsensor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Lichtsensor.Location = new System.Drawing.Point(0, 0);
            this.lbl_Lichtsensor.Name = "lbl_Lichtsensor";
            this.lbl_Lichtsensor.Size = new System.Drawing.Size(99, 13);
            this.lbl_Lichtsensor.TabIndex = 5;
            this.lbl_Lichtsensor.Text = "Lichtsensor reagiert";
            // 
            // ckLichtsensor
            // 
            this.ckLichtsensor.AutoSize = true;
            this.ckLichtsensor.Location = new System.Drawing.Point(19, 16);
            this.ckLichtsensor.Name = "ckLichtsensor";
            this.ckLichtsensor.Size = new System.Drawing.Size(15, 14);
            this.ckLichtsensor.TabIndex = 6;
            this.ckLichtsensor.UseVisualStyleBackColor = true;
            this.ckLichtsensor.CheckedChanged += new System.EventHandler(this.ckLichtsensor_CheckedChanged);
            // 
            // pl_Augendusche
            // 
            this.pl_Augendusche.Controls.Add(this.ckAugendusche);
            this.pl_Augendusche.Controls.Add(this.lbl_Augendusche);
            this.pl_Augendusche.Location = new System.Drawing.Point(3, 135);
            this.pl_Augendusche.Name = "pl_Augendusche";
            this.pl_Augendusche.Size = new System.Drawing.Size(172, 38);
            this.pl_Augendusche.TabIndex = 13;
            // 
            // ckAugendusche
            // 
            this.ckAugendusche.AutoSize = true;
            this.ckAugendusche.Location = new System.Drawing.Point(19, 16);
            this.ckAugendusche.Name = "ckAugendusche";
            this.ckAugendusche.Size = new System.Drawing.Size(15, 14);
            this.ckAugendusche.TabIndex = 6;
            this.ckAugendusche.UseVisualStyleBackColor = true;
            this.ckAugendusche.CheckedChanged += new System.EventHandler(this.ckAugendusche_CheckedChanged);
            // 
            // lbl_Augendusche
            // 
            this.lbl_Augendusche.AutoSize = true;
            this.lbl_Augendusche.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Augendusche.Location = new System.Drawing.Point(0, 0);
            this.lbl_Augendusche.Name = "lbl_Augendusche";
            this.lbl_Augendusche.Size = new System.Drawing.Size(96, 13);
            this.lbl_Augendusche.TabIndex = 5;
            this.lbl_Augendusche.Text = "Augendusche läuft";
            // 
            // pl_Ganzkörperdusche
            // 
            this.pl_Ganzkörperdusche.Controls.Add(this.ckGanzkörperdusche);
            this.pl_Ganzkörperdusche.Controls.Add(this.lbl_Ganzkörperdusche);
            this.pl_Ganzkörperdusche.Location = new System.Drawing.Point(3, 179);
            this.pl_Ganzkörperdusche.Name = "pl_Ganzkörperdusche";
            this.pl_Ganzkörperdusche.Size = new System.Drawing.Size(172, 38);
            this.pl_Ganzkörperdusche.TabIndex = 14;
            // 
            // ckGanzkörperdusche
            // 
            this.ckGanzkörperdusche.AutoSize = true;
            this.ckGanzkörperdusche.Location = new System.Drawing.Point(19, 16);
            this.ckGanzkörperdusche.Name = "ckGanzkörperdusche";
            this.ckGanzkörperdusche.Size = new System.Drawing.Size(15, 14);
            this.ckGanzkörperdusche.TabIndex = 6;
            this.ckGanzkörperdusche.UseVisualStyleBackColor = true;
            this.ckGanzkörperdusche.CheckedChanged += new System.EventHandler(this.ckGanzkörperdusche_CheckedChanged);
            // 
            // lbl_Ganzkörperdusche
            // 
            this.lbl_Ganzkörperdusche.AutoSize = true;
            this.lbl_Ganzkörperdusche.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Ganzkörperdusche.Location = new System.Drawing.Point(0, 0);
            this.lbl_Ganzkörperdusche.Name = "lbl_Ganzkörperdusche";
            this.lbl_Ganzkörperdusche.Size = new System.Drawing.Size(120, 13);
            this.lbl_Ganzkörperdusche.TabIndex = 5;
            this.lbl_Ganzkörperdusche.Text = "Ganzkörperdusche läuft";
            // 
            // showFlussrate
            // 
            this.showFlussrate.Dock = System.Windows.Forms.DockStyle.Right;
            this.showFlussrate.Location = new System.Drawing.Point(327, 0);
            this.showFlussrate.Name = "showFlussrate";
            this.showFlussrate.Size = new System.Drawing.Size(46, 38);
            this.showFlussrate.TabIndex = 6;
            this.showFlussrate.Text = "-";
            this.showFlussrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showWasserdruck
            // 
            this.showWasserdruck.Dock = System.Windows.Forms.DockStyle.Right;
            this.showWasserdruck.Location = new System.Drawing.Point(327, 0);
            this.showWasserdruck.Name = "showWasserdruck";
            this.showWasserdruck.Size = new System.Drawing.Size(46, 38);
            this.showWasserdruck.TabIndex = 7;
            this.showWasserdruck.Text = "-";
            this.showWasserdruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showWassertemperatur
            // 
            this.showWassertemperatur.Dock = System.Windows.Forms.DockStyle.Right;
            this.showWassertemperatur.Location = new System.Drawing.Point(327, 0);
            this.showWassertemperatur.Name = "showWassertemperatur";
            this.showWassertemperatur.Size = new System.Drawing.Size(46, 38);
            this.showWassertemperatur.TabIndex = 7;
            this.showWassertemperatur.Text = "-";
            this.showWassertemperatur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showUmgebungstemperatur
            // 
            this.showUmgebungstemperatur.Dock = System.Windows.Forms.DockStyle.Right;
            this.showUmgebungstemperatur.Location = new System.Drawing.Point(327, 0);
            this.showUmgebungstemperatur.Name = "showUmgebungstemperatur";
            this.showUmgebungstemperatur.Size = new System.Drawing.Size(46, 38);
            this.showUmgebungstemperatur.TabIndex = 7;
            this.showUmgebungstemperatur.Text = "-";
            this.showUmgebungstemperatur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showWasserstand
            // 
            this.showWasserstand.Dock = System.Windows.Forms.DockStyle.Right;
            this.showWasserstand.Location = new System.Drawing.Point(327, 0);
            this.showWasserstand.Name = "showWasserstand";
            this.showWasserstand.Size = new System.Drawing.Size(46, 38);
            this.showWasserstand.TabIndex = 7;
            this.showWasserstand.Text = "-";
            this.showWasserstand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showTankwassertemperatur
            // 
            this.showTankwassertemperatur.Dock = System.Windows.Forms.DockStyle.Right;
            this.showTankwassertemperatur.Location = new System.Drawing.Point(327, 0);
            this.showTankwassertemperatur.Name = "showTankwassertemperatur";
            this.showTankwassertemperatur.Size = new System.Drawing.Size(46, 38);
            this.showTankwassertemperatur.TabIndex = 7;
            this.showTankwassertemperatur.Text = "-";
            this.showTankwassertemperatur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_einstellungen
            // 
            this.pl_einstellungen.Controls.Add(this.pl_Flussrate);
            this.pl_einstellungen.Controls.Add(this.pl_Ganzkörperdusche);
            this.pl_einstellungen.Controls.Add(this.pl_Wasserdruck);
            this.pl_einstellungen.Controls.Add(this.pl_Augendusche);
            this.pl_einstellungen.Controls.Add(this.pl_Wassertemperatur);
            this.pl_einstellungen.Controls.Add(this.pl_Lichtsensor);
            this.pl_einstellungen.Controls.Add(this.pl_Umgebungstemperatur);
            this.pl_einstellungen.Controls.Add(this.pl_Tankwassertemperatur);
            this.pl_einstellungen.Controls.Add(this.pl_Wasserstand);
            this.pl_einstellungen.Location = new System.Drawing.Point(312, 12);
            this.pl_einstellungen.Name = "pl_einstellungen";
            this.pl_einstellungen.Size = new System.Drawing.Size(387, 408);
            this.pl_einstellungen.TabIndex = 15;
            this.pl_einstellungen.Visible = false;
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 432);
            this.Controls.Add(this.pl_einstellungen);
            this.Controls.Add(this.btn_duschelöschen);
            this.Controls.Add(this.btn_duschkabine);
            this.Controls.Add(this.btn_standdusche);
            this.Controls.Add(this.lb_duschenliste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Simulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.barFlussrate)).EndInit();
            this.pl_Flussrate.ResumeLayout(false);
            this.pl_Flussrate.PerformLayout();
            this.pl_Wasserdruck.ResumeLayout(false);
            this.pl_Wasserdruck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWasserdruck)).EndInit();
            this.pl_Wassertemperatur.ResumeLayout(false);
            this.pl_Wassertemperatur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWassertemperatur)).EndInit();
            this.pl_Umgebungstemperatur.ResumeLayout(false);
            this.pl_Umgebungstemperatur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barUmgebungstemperatur)).EndInit();
            this.pl_Wasserstand.ResumeLayout(false);
            this.pl_Wasserstand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barWasserstand)).EndInit();
            this.pl_Tankwassertemperatur.ResumeLayout(false);
            this.pl_Tankwassertemperatur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barTankwassertemperatur)).EndInit();
            this.pl_Lichtsensor.ResumeLayout(false);
            this.pl_Lichtsensor.PerformLayout();
            this.pl_Augendusche.ResumeLayout(false);
            this.pl_Augendusche.PerformLayout();
            this.pl_Ganzkörperdusche.ResumeLayout(false);
            this.pl_Ganzkörperdusche.PerformLayout();
            this.pl_einstellungen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_duschenliste;
        private System.Windows.Forms.Button btn_standdusche;
        private System.Windows.Forms.Button btn_duschkabine;
        private System.Windows.Forms.Button btn_duschelöschen;
        private System.Windows.Forms.TrackBar barFlussrate;
        private System.Windows.Forms.Label lbl_flussrate;
        private System.Windows.Forms.Panel pl_Flussrate;
        private System.Windows.Forms.Panel pl_Wasserdruck;
        private System.Windows.Forms.TrackBar barWasserdruck;
        private System.Windows.Forms.Label lbl_Wasserdruck;
        private System.Windows.Forms.Panel pl_Wassertemperatur;
        private System.Windows.Forms.TrackBar barWassertemperatur;
        private System.Windows.Forms.Label lbl_Wassertemperatur;
        private System.Windows.Forms.Panel pl_Umgebungstemperatur;
        private System.Windows.Forms.TrackBar barUmgebungstemperatur;
        private System.Windows.Forms.Label lbl_Umgebungstemperatur;
        private System.Windows.Forms.Panel pl_Wasserstand;
        private System.Windows.Forms.TrackBar barWasserstand;
        private System.Windows.Forms.Label lbl_Wasserstand;
        private System.Windows.Forms.Panel pl_Tankwassertemperatur;
        private System.Windows.Forms.TrackBar barTankwassertemperatur;
        private System.Windows.Forms.Label lbl_Tankwassertemperatur;
        private System.Windows.Forms.Panel pl_Lichtsensor;
        private System.Windows.Forms.CheckBox ckLichtsensor;
        private System.Windows.Forms.Label lbl_Lichtsensor;
        private System.Windows.Forms.Panel pl_Augendusche;
        private System.Windows.Forms.CheckBox ckAugendusche;
        private System.Windows.Forms.Label lbl_Augendusche;
        private System.Windows.Forms.Panel pl_Ganzkörperdusche;
        private System.Windows.Forms.CheckBox ckGanzkörperdusche;
        private System.Windows.Forms.Label lbl_Ganzkörperdusche;
        private System.Windows.Forms.Label showFlussrate;
        private System.Windows.Forms.Label showWasserdruck;
        private System.Windows.Forms.Label showWassertemperatur;
        private System.Windows.Forms.Label showUmgebungstemperatur;
        private System.Windows.Forms.Label showWasserstand;
        private System.Windows.Forms.Label showTankwassertemperatur;
        private System.Windows.Forms.Panel pl_einstellungen;
    }
}

