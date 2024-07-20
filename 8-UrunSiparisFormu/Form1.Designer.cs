namespace _8_UrunSiparisFormu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.grpFaturaTipleri = new System.Windows.Forms.GroupBox();
            this.rdBireysel = new System.Windows.Forms.RadioButton();
            this.rdKurumsal = new System.Windows.Forms.RadioButton();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lblSepetToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.grpFaturaTipleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(33, 63);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(473, 37);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Listesi";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 29;
            this.lstListe.Location = new System.Drawing.Point(33, 157);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(473, 236);
            this.lstListe.TabIndex = 3;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(33, 452);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(162, 35);
            this.nmrAdet.TabIndex = 4;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(210, 452);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(296, 35);
            this.txtBirimFiyat.TabIndex = 5;
            this.txtBirimFiyat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBirimFiyat_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birim Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(33, 522);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(473, 35);
            this.txtToplamTutar.TabIndex = 5;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 29;
            this.lstSepet.Location = new System.Drawing.Point(602, 292);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(259, 207);
            this.lstSepet.TabIndex = 3;
            // 
            // grpFaturaTipleri
            // 
            this.grpFaturaTipleri.Controls.Add(this.rdBireysel);
            this.grpFaturaTipleri.Controls.Add(this.rdKurumsal);
            this.grpFaturaTipleri.Location = new System.Drawing.Point(556, 115);
            this.grpFaturaTipleri.Name = "grpFaturaTipleri";
            this.grpFaturaTipleri.Size = new System.Drawing.Size(305, 160);
            this.grpFaturaTipleri.TabIndex = 6;
            this.grpFaturaTipleri.TabStop = false;
            this.grpFaturaTipleri.Text = "Fatura Tipi";
            // 
            // rdBireysel
            // 
            this.rdBireysel.AutoSize = true;
            this.rdBireysel.Location = new System.Drawing.Point(18, 97);
            this.rdBireysel.Name = "rdBireysel";
            this.rdBireysel.Size = new System.Drawing.Size(201, 33);
            this.rdBireysel.TabIndex = 1;
            this.rdBireysel.TabStop = true;
            this.rdBireysel.Text = "Bireysel Fatura";
            this.rdBireysel.UseVisualStyleBackColor = true;
            // 
            // rdKurumsal
            // 
            this.rdKurumsal.AutoSize = true;
            this.rdKurumsal.Location = new System.Drawing.Point(18, 58);
            this.rdKurumsal.Name = "rdKurumsal";
            this.rdKurumsal.Size = new System.Drawing.Size(218, 33);
            this.rdKurumsal.TabIndex = 0;
            this.rdKurumsal.TabStop = true;
            this.rdKurumsal.Text = "Kurumsal Fatura";
            this.rdKurumsal.UseVisualStyleBackColor = true;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(512, 452);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(84, 105);
            this.btnAktar.TabIndex = 7;
            this.btnAktar.Text = ">>>";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lblSepetToplam
            // 
            this.lblSepetToplam.Location = new System.Drawing.Point(602, 502);
            this.lblSepetToplam.Name = "lblSepetToplam";
            this.lblSepetToplam.Size = new System.Drawing.Size(259, 41);
            this.lblSepetToplam.TabIndex = 2;
            this.lblSepetToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 604);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.grpFaturaTipleri);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSepetToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.grpFaturaTipleri.ResumeLayout(false);
            this.grpFaturaTipleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.GroupBox grpFaturaTipleri;
        private System.Windows.Forms.RadioButton rdBireysel;
        private System.Windows.Forms.RadioButton rdKurumsal;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label lblSepetToplam;
    }
}

