namespace ÜberwachungNotfalldusche
{
    partial class Hauptansicht
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
      this.components = new System.ComponentModel.Container();
      this.refreshIntervall = new System.Windows.Forms.Timer(this.components);
      this.listview_showers = new System.Windows.Forms.ListView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_quit = new System.Windows.Forms.Button();
      this.btn_refresh = new System.Windows.Forms.Button();
      this.lb_warninglist = new System.Windows.Forms.ListBox();
      this.btn_testing = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // refreshIntervall
      // 
      this.refreshIntervall.Interval = 1000;
      this.refreshIntervall.Tick += new System.EventHandler(this.refreshIntervall_Tick);
      // 
      // listview_showers
      // 
      this.listview_showers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listview_showers.Location = new System.Drawing.Point(0, 0);
      this.listview_showers.MultiSelect = false;
      this.listview_showers.Name = "listview_showers";
      this.listview_showers.OwnerDraw = true;
      this.listview_showers.Size = new System.Drawing.Size(633, 347);
      this.listview_showers.TabIndex = 0;
      this.listview_showers.TileSize = new System.Drawing.Size(150, 400);
      this.listview_showers.UseCompatibleStateImageBehavior = false;
      this.listview_showers.View = System.Windows.Forms.View.Tile;
      this.listview_showers.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listview_showers_DrawItem);
      this.listview_showers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listview_showers_MouseUp);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_testing);
      this.panel1.Controls.Add(this.btn_quit);
      this.panel1.Controls.Add(this.btn_refresh);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(633, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(163, 495);
      this.panel1.TabIndex = 1;
      // 
      // btn_quit
      // 
      this.btn_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btn_quit.Location = new System.Drawing.Point(6, 416);
      this.btn_quit.Name = "btn_quit";
      this.btn_quit.Size = new System.Drawing.Size(145, 23);
      this.btn_quit.TabIndex = 1;
      this.btn_quit.Text = "Quittieren";
      this.btn_quit.UseVisualStyleBackColor = true;
      this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
      // 
      // btn_refresh
      // 
      this.btn_refresh.Location = new System.Drawing.Point(6, 12);
      this.btn_refresh.Name = "btn_refresh";
      this.btn_refresh.Size = new System.Drawing.Size(145, 23);
      this.btn_refresh.TabIndex = 0;
      this.btn_refresh.Text = "Aktualisieren";
      this.btn_refresh.UseVisualStyleBackColor = true;
      this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
      // 
      // lb_warninglist
      // 
      this.lb_warninglist.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lb_warninglist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lb_warninglist.FormattingEnabled = true;
      this.lb_warninglist.ItemHeight = 16;
      this.lb_warninglist.Location = new System.Drawing.Point(0, 347);
      this.lb_warninglist.Name = "lb_warninglist";
      this.lb_warninglist.Size = new System.Drawing.Size(633, 148);
      this.lb_warninglist.TabIndex = 2;
      // 
      // btn_testing
      // 
      this.btn_testing.Location = new System.Drawing.Point(6, 41);
      this.btn_testing.Name = "btn_testing";
      this.btn_testing.Size = new System.Drawing.Size(145, 23);
      this.btn_testing.TabIndex = 2;
      this.btn_testing.Text = "Automatischer Duschentest";
      this.btn_testing.UseVisualStyleBackColor = true;
      this.btn_testing.Click += new System.EventHandler(this.btn_testing_Click);
      // 
      // Hauptansicht
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(796, 495);
      this.Controls.Add(this.listview_showers);
      this.Controls.Add(this.lb_warninglist);
      this.Controls.Add(this.panel1);
      this.Name = "Hauptansicht";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Notfallduschen-Überwachung";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer refreshIntervall;
        private System.Windows.Forms.ListView listview_showers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ListBox lb_warninglist;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_testing;
    }
}

