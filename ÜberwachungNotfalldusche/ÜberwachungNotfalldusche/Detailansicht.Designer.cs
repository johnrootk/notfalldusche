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
      this.lbl_Wassertemperatur = new System.Windows.Forms.Label();
      this.pb_Image = new System.Windows.Forms.PictureBox();
      this.btn_test = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
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
      // lbl_Wassertemperatur
      // 
      this.lbl_Wassertemperatur.AutoSize = true;
      this.lbl_Wassertemperatur.Location = new System.Drawing.Point(27, 53);
      this.lbl_Wassertemperatur.Name = "lbl_Wassertemperatur";
      this.lbl_Wassertemperatur.Size = new System.Drawing.Size(10, 13);
      this.lbl_Wassertemperatur.TabIndex = 2;
      this.lbl_Wassertemperatur.Text = "-";
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
      this.btn_test.Location = new System.Drawing.Point(12, 350);
      this.btn_test.Name = "btn_test";
      this.btn_test.Size = new System.Drawing.Size(75, 23);
      this.btn_test.TabIndex = 3;
      this.btn_test.Text = "Testen";
      this.btn_test.UseVisualStyleBackColor = true;
      this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
      // 
      // Detailansicht
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(493, 385);
      this.Controls.Add(this.btn_test);
      this.Controls.Add(this.lbl_Wassertemperatur);
      this.Controls.Add(this.pb_Image);
      this.Controls.Add(this.lbl_Name);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Detailansicht";
      this.Text = "Detailansicht";
      ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label lbl_Wassertemperatur;
        private System.Windows.Forms.Button btn_test;
    }
}