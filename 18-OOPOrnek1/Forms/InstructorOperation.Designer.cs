namespace _18_OOPOrnek1.Forms
{
    partial class InstructorOperation
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtAd = new System.Windows.Forms.TextBox();
            grpBilgiler = new System.Windows.Forms.GroupBox();
            txtTelefon = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtUzmanlik = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtSoyad = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lstKurslar = new System.Windows.Forms.ListBox();
            lstAtananKurslar = new System.Windows.Forms.ListBox();
            btnKursAta = new System.Windows.Forms.Button();
            btnTemizle = new System.Windows.Forms.Button();
            btnKaydet = new System.Windows.Forms.Button();
            btnSil = new System.Windows.Forms.Button();
            btnGuncelle = new System.Windows.Forms.Button();
            lblHata = new System.Windows.Forms.Label();
            dgwEgitmenListesi = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            grpBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwEgitmenListesi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(574, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(235, 20);
            label1.TabIndex = 0;
            label1.Text = "EĞİTMEN İŞLEMLERİ FORMU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "AD";
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(187, 39);
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(268, 26);
            txtAd.TabIndex = 1;
            // 
            // grpBilgiler
            // 
            grpBilgiler.Controls.Add(txtTelefon);
            grpBilgiler.Controls.Add(label6);
            grpBilgiler.Controls.Add(txtUzmanlik);
            grpBilgiler.Controls.Add(label5);
            grpBilgiler.Controls.Add(txtEmail);
            grpBilgiler.Controls.Add(label4);
            grpBilgiler.Controls.Add(txtSoyad);
            grpBilgiler.Controls.Add(label3);
            grpBilgiler.Controls.Add(txtAd);
            grpBilgiler.Controls.Add(label2);
            grpBilgiler.Location = new System.Drawing.Point(17, 67);
            grpBilgiler.Name = "grpBilgiler";
            grpBilgiler.Size = new System.Drawing.Size(479, 218);
            grpBilgiler.TabIndex = 3;
            grpBilgiler.TabStop = false;
            grpBilgiler.Text = "Eğitmen Bilgileri";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new System.Drawing.Point(187, 167);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new System.Drawing.Size(268, 26);
            txtTelefon.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(26, 170);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(109, 20);
            label6.TabIndex = 1;
            label6.Text = "TELEFON NO";
            // 
            // txtUzmanlik
            // 
            txtUzmanlik.Location = new System.Drawing.Point(187, 135);
            txtUzmanlik.Name = "txtUzmanlik";
            txtUzmanlik.Size = new System.Drawing.Size(268, 26);
            txtUzmanlik.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(26, 138);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(141, 20);
            label5.TabIndex = 1;
            label5.Text = "UZMANLIK ALANI";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(187, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(268, 26);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(26, 106);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 20);
            label4.TabIndex = 1;
            label4.Text = "EMAİL";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new System.Drawing.Point(187, 71);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new System.Drawing.Size(268, 26);
            txtSoyad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 20);
            label3.TabIndex = 1;
            label3.Text = "SOYAD";
            // 
            // lstKurslar
            // 
            lstKurslar.FormattingEnabled = true;
            lstKurslar.ItemHeight = 20;
            lstKurslar.Location = new System.Drawing.Point(511, 77);
            lstKurslar.Name = "lstKurslar";
            lstKurslar.Size = new System.Drawing.Size(142, 204);
            lstKurslar.TabIndex = 4;
            // 
            // lstAtananKurslar
            // 
            lstAtananKurslar.FormattingEnabled = true;
            lstAtananKurslar.ItemHeight = 20;
            lstAtananKurslar.Location = new System.Drawing.Point(659, 77);
            lstAtananKurslar.Name = "lstAtananKurslar";
            lstAtananKurslar.Size = new System.Drawing.Size(142, 204);
            lstAtananKurslar.TabIndex = 4;
            // 
            // btnKursAta
            // 
            btnKursAta.Location = new System.Drawing.Point(511, 291);
            btnKursAta.Name = "btnKursAta";
            btnKursAta.Size = new System.Drawing.Size(142, 32);
            btnKursAta.TabIndex = 7;
            btnKursAta.Text = "Kurs Ata >>";
            btnKursAta.UseVisualStyleBackColor = true;
            btnKursAta.Click += btnKursAta_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new System.Drawing.Point(659, 291);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new System.Drawing.Size(142, 32);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(17, 291);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(293, 32);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Eğitmen Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new System.Drawing.Point(659, 496);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(142, 32);
            btnSil.TabIndex = 10;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new System.Drawing.Point(316, 291);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(180, 32);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lblHata
            // 
            lblHata.BackColor = System.Drawing.Color.OrangeRed;
            lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblHata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblHata.Location = new System.Drawing.Point(23, 35);
            lblHata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHata.Name = "lblHata";
            lblHata.Size = new System.Drawing.Size(778, 29);
            lblHata.TabIndex = 0;
            // 
            // dgwEgitmenListesi
            // 
            dgwEgitmenListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEgitmenListesi.Location = new System.Drawing.Point(23, 329);
            dgwEgitmenListesi.Name = "dgwEgitmenListesi";
            dgwEgitmenListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgwEgitmenListesi.Size = new System.Drawing.Size(778, 150);
            dgwEgitmenListesi.TabIndex = 8;
            dgwEgitmenListesi.CellClick += dgwEgitmenListesi_CellClick;
            dgwEgitmenListesi.RowEnter += dgwEgitmenListesi_RowEnter;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(329, 498);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(324, 30);
            button1.TabIndex = 11;
            button1.Text = "STATİC CLASS TEST EDİLDİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InstructorOperation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(822, 543);
            Controls.Add(button1);
            Controls.Add(dgwEgitmenListesi);
            Controls.Add(btnTemizle);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnKursAta);
            Controls.Add(lstAtananKurslar);
            Controls.Add(lstKurslar);
            Controls.Add(grpBilgiler);
            Controls.Add(lblHata);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "InstructorOperation";
            Text = "InstructorOperation";
            Load += InstructorOperation_Load;
            grpBilgiler.ResumeLayout(false);
            grpBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwEgitmenListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox grpBilgiler;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstKurslar;
        private System.Windows.Forms.ListBox lstAtananKurslar;
        private System.Windows.Forms.Button btnKursAta;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.DataGridView dgwEgitmenListesi;
        private System.Windows.Forms.Button button1;
    }
}