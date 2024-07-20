namespace _1.Degiskenler
{
    partial class Ornek1
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdedi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(282, 316);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 58);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(26, 121);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(418, 35);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // txtUrunAdedi
            // 
            this.txtUrunAdedi.Location = new System.Drawing.Point(26, 195);
            this.txtUrunAdedi.Name = "txtUrunAdedi";
            this.txtUrunAdedi.Size = new System.Drawing.Size(418, 35);
            this.txtUrunAdedi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adedi";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(26, 265);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(418, 35);
            this.txtUrunFiyati.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // lblMesaj
            // 
            this.lblMesaj.Location = new System.Drawing.Point(30, 401);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(414, 123);
            this.lblMesaj.TabIndex = 3;
            // 
            // lblTarih
            // 
            this.lblTarih.Location = new System.Drawing.Point(21, 21);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(423, 29);
            this.lblTarih.TabIndex = 2;
            // 
            // Ornek1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 564);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAdedi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Ornek1";
            this.Text = "Ornek1";
            this.Load += new System.EventHandler(this.Ornek1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdedi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblTarih;
    }
}