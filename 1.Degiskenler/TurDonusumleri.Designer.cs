namespace _1.Degiskenler
{
    partial class TurDonusumleri
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
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(17, 56);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(440, 35);
            this.txtStokMiktari.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(264, 97);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(193, 57);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.Location = new System.Drawing.Point(12, 200);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(445, 91);
            this.lblMesaj.TabIndex = 2;
            // 
            // TurDonusumleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 402);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtStokMiktari);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "TurDonusumleri";
            this.Text = "TurDonusumleri";
            this.Load += new System.EventHandler(this.TurDonusumleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblMesaj;
    }
}