namespace _18_OOPOrnek1.Forms
{
    partial class StudentOperations
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
            grpOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            txtDTarihi = new System.Windows.Forms.MaskedTextBox();
            txtTC = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtSoyad = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtAd = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnKaydet = new System.Windows.Forms.Button();
            lstListe = new System.Windows.Forms.ListBox();
            btnSil = new System.Windows.Forms.Button();
            grpOgrenciBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenciBilgileri
            // 
            grpOgrenciBilgileri.Controls.Add(txtDTarihi);
            grpOgrenciBilgileri.Controls.Add(txtTC);
            grpOgrenciBilgileri.Controls.Add(label4);
            grpOgrenciBilgileri.Controls.Add(label3);
            grpOgrenciBilgileri.Controls.Add(txtSoyad);
            grpOgrenciBilgileri.Controls.Add(label2);
            grpOgrenciBilgileri.Controls.Add(txtAd);
            grpOgrenciBilgileri.Controls.Add(label1);
            grpOgrenciBilgileri.Location = new System.Drawing.Point(0, 0);
            grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            grpOgrenciBilgileri.Size = new System.Drawing.Size(692, 303);
            grpOgrenciBilgileri.TabIndex = 0;
            grpOgrenciBilgileri.TabStop = false;
            grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // txtDTarihi
            // 
            txtDTarihi.Location = new System.Drawing.Point(226, 242);
            txtDTarihi.Mask = "00/00/0000";
            txtDTarihi.Name = "txtDTarihi";
            txtDTarihi.Size = new System.Drawing.Size(460, 50);
            txtDTarihi.TabIndex = 2;
            txtDTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtTC
            // 
            txtTC.Location = new System.Drawing.Point(226, 74);
            txtTC.Name = "txtTC";
            txtTC.Size = new System.Drawing.Size(460, 50);
            txtTC.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 74);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(152, 45);
            label4.TabIndex = 0;
            label4.Text = "TC Kimlik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(209, 45);
            label3.TabIndex = 0;
            label3.Text = "Doğum Tarihi";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new System.Drawing.Point(226, 186);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new System.Drawing.Size(460, 50);
            txtSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 45);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(226, 130);
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(460, 50);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 130);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 45);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(486, 309);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(206, 65);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 45;
            lstListe.Location = new System.Drawing.Point(12, 380);
            lstListe.Name = "lstListe";
            lstListe.Size = new System.Drawing.Size(680, 184);
            lstListe.TabIndex = 3;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new System.Drawing.Point(486, 570);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(206, 65);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // StudentOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(724, 641);
            Controls.Add(lstListe);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(grpOgrenciBilgileri);
            Font = new System.Drawing.Font("Segoe UI", 24F);
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            Name = "StudentOperations";
            Text = "StudentOperations";
            Load += StudentOperations_Load;
            grpOgrenciBilgileri.ResumeLayout(false);
            grpOgrenciBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenciBilgileri;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.MaskedTextBox txtDTarihi;
        private System.Windows.Forms.Button btnSil;
    }
}