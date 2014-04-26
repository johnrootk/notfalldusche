namespace ÜberwachungNotfalldusche
{
    partial class Detailansicht
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
      this.components = new System.ComponentModel.Container();
      this.lbl_Name = new System.Windows.Forms.Label();
      this.refreshTimer = new System.Windows.Forms.Timer(this.components);
      this.val_flussrate = new System.Windows.Forms.Label();
      this.pb_Image = new System.Windows.Forms.PictureBox();
      this.btn_test = new System.Windows.Forms.Button();
      this.lbl_flussrate = new System.Windows.Forms.Label();
      this.lbl_wasserdruck = new System.Windows.Forms.Label();
      this.lbl_wassertemperatur = new System.Windows.Forms.Label();
      this.lbl_umgebungstemperatur = new System.Windows.Forms.Label();
      this.lbl_wasserstand = new System.Windows.Forms.Label();
      this.lbl_Tankwassertemp = new System.Windows.Forms.Label();
      this.gb_status = new System.Windows.Forms.GroupBox();
      this.val_wasserdruck = new System.Windows.Forms.Label();
      this.val_wassertemperatur = new System.Windows.Forms.Label();
      this.val_umgebungstemperatur = new System.Windows.Forms.Label();
      this.val_tankwasserstand = new System.Windows.Forms.Label();
      this.val_tankwassertemp = new System.Windows.Forms.Label();
      this.lbl_schalteraugen = new System.Windows.Forms.Label();
      this.lbl_schalterdusche = new System.Windows.Forms.Label();
      this.lbl_erreichbarkeit = new System.Windows.Forms.Label();
      this.lbl_lichtsensor = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
      this.gb_status.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbl_Name
      // 
      this.lbl_Name.AutoSize = true;
      this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Name.Location = new System.Drawing.Point(12, 9);
      this.lbl_Name.Name = "lbl_Name";
      this.lbl_Name.Size = new System.Drawing.Size(66, 24);
      this.lbl_Name.TabIndex = 0;
      this.lbl_Name.Text = "label1";
      // 
      // refreshTimer
      // 
      this.refreshTimer.Interval = 2000;
      this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
      // 
      // val_flussrate
      // 
      this.val_flussrate.AutoSize = true;
      this.val_flussrate.Location = new System.Drawing.Point(49, 59);
      this.val_flussrate.Name = "val_flussrate";
      this.val_flussrate.Size = new System.Drawing.Size(10, 13);
      this.val_flussrate.TabIndex = 2;
      this.val_flussrate.Text = "-";
      // 
      // pb_Image
      // 
      this.pb_Image.Location = new System.Drawing.Point(293, 12);
      this.pb_Image.Name = "pb_Image";
      this.pb_Image.Size = new System.Drawing.Size(187, 361);
      this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pb_Image.TabIndex = 1;
      this.pb_Image.TabStop = false;
      // 
      // btn_test
      // 
      this.btn_test.Location = new System.Drawing.Point(71, 350);
      this.btn_test.Name = "btn_test";
      this.btn_test.Size = new System.Drawing.Size(134, 23);
      this.btn_test.TabIndex = 3;
      this.btn_test.Text = "Testen";
      this.btn_test.UseVisualStyleBackColor = true;
      this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
      // 
      // lbl_flussrate
      // 
      this.lbl_flussrate.AutoSize = true;
      this.lbl_flussrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_flussrate.Location = new System.Drawing.Point(22, 43);
      this.lbl_flussrate.Name = "lbl_flussrate";
      this.lbl_flussrate.Size = new System.Drawing.Size(76, 16);
      this.lbl_flussrate.TabIndex = 4;
      this.lbl_flussrate.Text = "Flussrate:";
      // 
      // lbl_wasserdruck
      // 
      this.lbl_wasserdruck.AutoSize = true;
      this.lbl_wasserdruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_wasserdruck.Location = new System.Drawing.Point(22, 74);
      this.lbl_wasserdruck.Name = "lbl_wasserdruck";
      this.lbl_wasserdruck.Size = new System.Drawing.Size(103, 16);
      this.lbl_wasserdruck.TabIndex = 5;
      this.lbl_wasserdruck.Text = "Wasserdruck:";
      // 
      // lbl_wassertemperatur
      // 
      this.lbl_wassertemperatur.AutoSize = true;
      this.lbl_wassertemperatur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_wassertemperatur.Location = new System.Drawing.Point(22, 105);
      this.lbl_wassertemperatur.Name = "lbl_wassertemperatur";
      this.lbl_wassertemperatur.Size = new System.Drawing.Size(139, 16);
      this.lbl_wassertemperatur.TabIndex = 6;
      this.lbl_wassertemperatur.Text = "Wassertemperatur:";
      // 
      // lbl_umgebungstemperatur
      // 
      this.lbl_umgebungstemperatur.AutoSize = true;
      this.lbl_umgebungstemperatur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_umgebungstemperatur.Location = new System.Drawing.Point(22, 136);
      this.lbl_umgebungstemperatur.Name = "lbl_umgebungstemperatur";
      this.lbl_umgebungstemperatur.Size = new System.Drawing.Size(169, 16);
      this.lbl_umgebungstemperatur.TabIndex = 8;
      this.lbl_umgebungstemperatur.Text = "Umgebungstemperatur:";
      // 
      // lbl_wasserstand
      // 
      this.lbl_wasserstand.AutoSize = true;
      this.lbl_wasserstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_wasserstand.Location = new System.Drawing.Point(22, 167);
      this.lbl_wasserstand.Name = "lbl_wasserstand";
      this.lbl_wasserstand.Size = new System.Drawing.Size(134, 16);
      this.lbl_wasserstand.TabIndex = 9;
      this.lbl_wasserstand.Text = "Tankwasserstand:";
      // 
      // lbl_Tankwassertemp
      // 
      this.lbl_Tankwassertemp.AutoSize = true;
      this.lbl_Tankwassertemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Tankwassertemp.Location = new System.Drawing.Point(22, 198);
      this.lbl_Tankwassertemp.Name = "lbl_Tankwassertemp";
      this.lbl_Tankwassertemp.Size = new System.Drawing.Size(134, 16);
      this.lbl_Tankwassertemp.TabIndex = 10;
      this.lbl_Tankwassertemp.Text = "Tankwassertemp.:";
      // 
      // gb_status
      // 
      this.gb_status.Controls.Add(this.lbl_lichtsensor);
      this.gb_status.Controls.Add(this.lbl_erreichbarkeit);
      this.gb_status.Controls.Add(this.lbl_schalterdusche);
      this.gb_status.Controls.Add(this.lbl_schalteraugen);
      this.gb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_status.Location = new System.Drawing.Point(25, 235);
      this.gb_status.Name = "gb_status";
      this.gb_status.Size = new System.Drawing.Size(238, 109);
      this.gb_status.TabIndex = 11;
      this.gb_status.TabStop = false;
      this.gb_status.Text = "Status:";
      // 
      // val_wasserdruck
      // 
      this.val_wasserdruck.AutoSize = true;
      this.val_wasserdruck.Location = new System.Drawing.Point(49, 90);
      this.val_wasserdruck.Name = "val_wasserdruck";
      this.val_wasserdruck.Size = new System.Drawing.Size(10, 13);
      this.val_wasserdruck.TabIndex = 12;
      this.val_wasserdruck.Text = "-";
      // 
      // val_wassertemperatur
      // 
      this.val_wassertemperatur.AutoSize = true;
      this.val_wassertemperatur.Location = new System.Drawing.Point(49, 121);
      this.val_wassertemperatur.Name = "val_wassertemperatur";
      this.val_wassertemperatur.Size = new System.Drawing.Size(10, 13);
      this.val_wassertemperatur.TabIndex = 13;
      this.val_wassertemperatur.Text = "-";
      // 
      // val_umgebungstemperatur
      // 
      this.val_umgebungstemperatur.AutoSize = true;
      this.val_umgebungstemperatur.Location = new System.Drawing.Point(49, 152);
      this.val_umgebungstemperatur.Name = "val_umgebungstemperatur";
      this.val_umgebungstemperatur.Size = new System.Drawing.Size(10, 13);
      this.val_umgebungstemperatur.TabIndex = 14;
      this.val_umgebungstemperatur.Text = "-";
      // 
      // val_tankwasserstand
      // 
      this.val_tankwasserstand.AutoSize = true;
      this.val_tankwasserstand.Location = new System.Drawing.Point(49, 183);
      this.val_tankwasserstand.Name = "val_tankwasserstand";
      this.val_tankwasserstand.Size = new System.Drawing.Size(10, 13);
      this.val_tankwasserstand.TabIndex = 15;
      this.val_tankwasserstand.Text = "-";
      // 
      // val_tankwassertemp
      // 
      this.val_tankwassertemp.AutoSize = true;
      this.val_tankwassertemp.Location = new System.Drawing.Point(49, 214);
      this.val_tankwassertemp.Name = "val_tankwassertemp";
      this.val_tankwassertemp.Size = new System.Drawing.Size(10, 13);
      this.val_tankwassertemp.TabIndex = 16;
      this.val_tankwassertemp.Text = "-";
      // 
      // lbl_schalteraugen
      // 
      this.lbl_schalteraugen.AutoSize = true;
      this.lbl_schalteraugen.Enabled = false;
      this.lbl_schalteraugen.Location = new System.Drawing.Point(22, 20);
      this.lbl_schalteraugen.Name = "lbl_schalteraugen";
      this.lbl_schalteraugen.Size = new System.Drawing.Size(135, 16);
      this.lbl_schalteraugen.TabIndex = 0;
      this.lbl_schalteraugen.Text = "Augendusche läuft";
      // 
      // lbl_schalterdusche
      // 
      this.lbl_schalterdusche.AutoSize = true;
      this.lbl_schalterdusche.Enabled = false;
      this.lbl_schalterdusche.Location = new System.Drawing.Point(22, 41);
      this.lbl_schalterdusche.Name = "lbl_schalterdusche";
      this.lbl_schalterdusche.Size = new System.Drawing.Size(137, 16);
      this.lbl_schalterdusche.TabIndex = 1;
      this.lbl_schalterdusche.Text = "Körperdusche läuft";
      // 
      // lbl_erreichbarkeit
      // 
      this.lbl_erreichbarkeit.AutoSize = true;
      this.lbl_erreichbarkeit.Location = new System.Drawing.Point(22, 62);
      this.lbl_erreichbarkeit.Name = "lbl_erreichbarkeit";
      this.lbl_erreichbarkeit.Size = new System.Drawing.Size(135, 16);
      this.lbl_erreichbarkeit.TabIndex = 2;
      this.lbl_erreichbarkeit.Text = "Dusche erreichbar";
      // 
      // lbl_lichtsensor
      // 
      this.lbl_lichtsensor.AutoSize = true;
      this.lbl_lichtsensor.Location = new System.Drawing.Point(22, 83);
      this.lbl_lichtsensor.Name = "lbl_lichtsensor";
      this.lbl_lichtsensor.Size = new System.Drawing.Size(77, 16);
      this.lbl_lichtsensor.TabIndex = 3;
      this.lbl_lichtsensor.Text = "Licht aktiv";
      // 
      // Detailansicht
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(493, 385);
      this.Controls.Add(this.val_tankwassertemp);
      this.Controls.Add(this.val_tankwasserstand);
      this.Controls.Add(this.val_umgebungstemperatur);
      this.Controls.Add(this.val_wassertemperatur);
      this.Controls.Add(this.val_wasserdruck);
      this.Controls.Add(this.gb_status);
      this.Controls.Add(this.lbl_Tankwassertemp);
      this.Controls.Add(this.lbl_wasserstand);
      this.Controls.Add(this.lbl_umgebungstemperatur);
      this.Controls.Add(this.lbl_wassertemperatur);
      this.Controls.Add(this.lbl_wasserdruck);
      this.Controls.Add(this.lbl_flussrate);
      this.Controls.Add(this.btn_test);
      this.Controls.Add(this.val_flussrate);
      this.Controls.Add(this.pb_Image);
      this.Controls.Add(this.lbl_Name);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Detailansicht";
      this.Text = "Detailansicht";
      ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
      this.gb_status.ResumeLayout(false);
      this.gb_status.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label val_flussrate;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lbl_flussrate;
        private System.Windows.Forms.Label lbl_wasserdruck;
        private System.Windows.Forms.Label lbl_wassertemperatur;
        private System.Windows.Forms.Label lbl_umgebungstemperatur;
        private System.Windows.Forms.Label lbl_wasserstand;
        private System.Windows.Forms.Label lbl_Tankwassertemp;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Label val_wasserdruck;
        private System.Windows.Forms.Label val_wassertemperatur;
        private System.Windows.Forms.Label val_umgebungstemperatur;
        private System.Windows.Forms.Label val_tankwasserstand;
        private System.Windows.Forms.Label val_tankwassertemp;
        private System.Windows.Forms.Label lbl_lichtsensor;
        private System.Windows.Forms.Label lbl_erreichbarkeit;
        private System.Windows.Forms.Label lbl_schalterdusche;
        private System.Windows.Forms.Label lbl_schalteraugen;
    }
}