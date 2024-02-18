namespace WeatherMapApp
{
    partial class HourlyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Sicaklik = new System.Windows.Forms.Label();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Sicaklik
            // 
            this.lbl_Sicaklik.AutoSize = true;
            this.lbl_Sicaklik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sicaklik.ForeColor = System.Drawing.Color.White;
            this.lbl_Sicaklik.Location = new System.Drawing.Point(63, 97);
            this.lbl_Sicaklik.Name = "lbl_Sicaklik";
            this.lbl_Sicaklik.Size = new System.Drawing.Size(57, 20);
            this.lbl_Sicaklik.TabIndex = 4;
            this.lbl_Sicaklik.Text = "label1";
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Durum.ForeColor = System.Drawing.Color.White;
            this.lbl_Durum.Location = new System.Drawing.Point(63, 123);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(46, 17);
            this.lbl_Durum.TabIndex = 4;
            this.lbl_Durum.Text = "label1";
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tarih.ForeColor = System.Drawing.Color.White;
            this.lbl_Tarih.Location = new System.Drawing.Point(20, 0);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(46, 17);
            this.lbl_Tarih.TabIndex = 5;
            this.lbl_Tarih.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HourlyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.lbl_Durum);
            this.Controls.Add(this.lbl_Sicaklik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HourlyControl";
            this.Size = new System.Drawing.Size(183, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Sicaklik;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.Label lbl_Tarih;
    }
}
