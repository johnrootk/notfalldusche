namespace ÜberwachungNotfalldusche
{
    partial class ÜberwachungHauptseite
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
            this.btn_refresh = new System.Windows.Forms.Button();
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
            this.listview_showers.Size = new System.Drawing.Size(633, 495);
            this.listview_showers.TabIndex = 0;
            this.listview_showers.TileSize = new System.Drawing.Size(150, 400);
            this.listview_showers.UseCompatibleStateImageBehavior = false;
            this.listview_showers.View = System.Windows.Forms.View.Tile;
            this.listview_showers.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listview_showers_DrawItem);
            this.listview_showers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listview_showers_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(633, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 495);
            this.panel1.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.Location = new System.Drawing.Point(6, 460);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(105, 23);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Aktualisieren";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ÜberwachungHauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 495);
            this.Controls.Add(this.listview_showers);
            this.Controls.Add(this.panel1);
            this.Name = "ÜberwachungHauptseite";
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
    }
}

