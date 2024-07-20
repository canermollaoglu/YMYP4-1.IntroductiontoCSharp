namespace _20_EntityFrameworkCodeFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtKategoriAdi = new TextBox();
            txtKategoriAciklama = new TextBox();
            label2 = new Label();
            btnKaydet = new Button();
            lstListe = new ListBox();
            btnUrunKaydet = new Button();
            txtUrunFiyati = new TextBox();
            label3 = new Label();
            txtUrunAdi = new TextBox();
            label4 = new Label();
            txtUrunAciklama = new TextBox();
            label5 = new Label();
            txtStokMiktari = new TextBox();
            label6 = new Label();
            dgwUrunListesi = new DataGridView();
            btnUrunSil = new Button();
            btnKategoriGuncelle = new Button();
            btnTemizle = new Button();
            lstFiltre = new ListBox();
            btnGetir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwUrunListesi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(278, 52);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(504, 43);
            txtKategoriAdi.TabIndex = 1;
            // 
            // txtKategoriAciklama
            // 
            txtKategoriAciklama.Location = new Point(278, 101);
            txtKategoriAciklama.Name = "txtKategoriAciklama";
            txtKategoriAciklama.Size = new Size(504, 43);
            txtKategoriAciklama.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(232, 37);
            label2.TabIndex = 2;
            label2.Text = "Kategori Açıklama";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(556, 150);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(226, 51);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kategori Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(800, 50);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(235, 226);
            lstListe.TabIndex = 5;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnUrunKaydet
            // 
            btnUrunKaydet.Location = new Point(556, 478);
            btnUrunKaydet.Name = "btnUrunKaydet";
            btnUrunKaydet.Size = new Size(226, 51);
            btnUrunKaydet.TabIndex = 10;
            btnUrunKaydet.Text = "Ürün Kaydet";
            btnUrunKaydet.UseVisualStyleBackColor = true;
            btnUrunKaydet.Click += btnUrunKaydet_Click;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(278, 331);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(504, 43);
            txtUrunFiyati.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 331);
            label3.Name = "label3";
            label3.Size = new Size(145, 37);
            label3.TabIndex = 8;
            label3.Text = "Ürün Fiyatı";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(278, 282);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(504, 43);
            txtUrunAdi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 282);
            label4.Name = "label4";
            label4.Size = new Size(122, 37);
            label4.TabIndex = 6;
            label4.Text = "Ürün Adı";
            // 
            // txtUrunAciklama
            // 
            txtUrunAciklama.Location = new Point(278, 380);
            txtUrunAciklama.Name = "txtUrunAciklama";
            txtUrunAciklama.Size = new Size(504, 43);
            txtUrunAciklama.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 380);
            label5.Name = "label5";
            label5.Size = new Size(207, 37);
            label5.TabIndex = 11;
            label5.Text = "Ürün Açıklaması";
            // 
            // txtStokMiktari
            // 
            txtStokMiktari.Location = new Point(278, 429);
            txtStokMiktari.Name = "txtStokMiktari";
            txtStokMiktari.Size = new Size(504, 43);
            txtStokMiktari.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 429);
            label6.Name = "label6";
            label6.Size = new Size(158, 37);
            label6.TabIndex = 13;
            label6.Text = "Stok Miktarı";
            // 
            // dgwUrunListesi
            // 
            dgwUrunListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwUrunListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwUrunListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUrunListesi.Location = new Point(26, 535);
            dgwUrunListesi.MultiSelect = false;
            dgwUrunListesi.Name = "dgwUrunListesi";
            dgwUrunListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwUrunListesi.Size = new Size(756, 176);
            dgwUrunListesi.TabIndex = 15;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(345, 478);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(205, 51);
            btnUrunSil.TabIndex = 16;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnKategoriGuncelle
            // 
            btnKategoriGuncelle.Location = new Point(278, 150);
            btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            btnKategoriGuncelle.Size = new Size(272, 51);
            btnKategoriGuncelle.TabIndex = 17;
            btnKategoriGuncelle.Text = "Kategori Güncelle";
            btnKategoriGuncelle.UseVisualStyleBackColor = true;
            btnKategoriGuncelle.Click += btnKategoriGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(278, 207);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(272, 49);
            btnTemizle.TabIndex = 18;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lstFiltre
            // 
            lstFiltre.FormattingEnabled = true;
            lstFiltre.ItemHeight = 37;
            lstFiltre.Location = new Point(800, 300);
            lstFiltre.Name = "lstFiltre";
            lstFiltre.Size = new Size(235, 337);
            lstFiltre.TabIndex = 5;
            lstFiltre.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(800, 657);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(235, 51);
            btnGetir.TabIndex = 10;
            btnGetir.Text = "Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 720);
            Controls.Add(btnTemizle);
            Controls.Add(btnKategoriGuncelle);
            Controls.Add(btnUrunSil);
            Controls.Add(dgwUrunListesi);
            Controls.Add(txtStokMiktari);
            Controls.Add(label6);
            Controls.Add(txtUrunAciklama);
            Controls.Add(label5);
            Controls.Add(btnGetir);
            Controls.Add(btnUrunKaydet);
            Controls.Add(txtUrunFiyati);
            Controls.Add(label3);
            Controls.Add(txtUrunAdi);
            Controls.Add(label4);
            Controls.Add(lstFiltre);
            Controls.Add(lstListe);
            Controls.Add(btnKaydet);
            Controls.Add(txtKategoriAciklama);
            Controls.Add(label2);
            Controls.Add(txtKategoriAdi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwUrunListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKategoriAdi;
        private TextBox txtKategoriAciklama;
        private Label label2;
        private Button btnKaydet;
        private ListBox lstListe;
        private Button btnUrunKaydet;
        private TextBox txtUrunFiyati;
        private Label label3;
        private TextBox txtUrunAdi;
        private Label label4;
        private TextBox txtUrunAciklama;
        private Label label5;
        private TextBox txtStokMiktari;
        private Label label6;
        private DataGridView dgwUrunListesi;
        private Button btnUrunSil;
        private Button btnKategoriGuncelle;
        private Button btnTemizle;
        private ListBox lstFiltre;
        private Button btnGetir;
    }
}
