namespace _19_BankProject
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
            groupBox1 = new GroupBox();
            btnHesapAc = new Button();
            cmbHesapTuru = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtAySonuBakiye = new TextBox();
            txtIlkBakiye = new TextBox();
            txtAdSoyad = new TextBox();
            txtHesapNo = new TextBox();
            groupBox2 = new GroupBox();
            btnIslemYap = new Button();
            cmbIslemTuru = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtIslemNotu = new TextBox();
            txtTutar = new TextBox();
            groupBox3 = new GroupBox();
            lblHesapHareketleri = new Label();
            lblSonBakiye = new Label();
            btnAySonu = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesapAc);
            groupBox1.Controls.Add(cmbHesapTuru);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAySonuBakiye);
            groupBox1.Controls.Add(txtIlkBakiye);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtHesapNo);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "HESAP AÇMA İŞLEMLERİ";
            // 
            // btnHesapAc
            // 
            btnHesapAc.Location = new Point(314, 297);
            btnHesapAc.Name = "btnHesapAc";
            btnHesapAc.Size = new Size(456, 62);
            btnHesapAc.TabIndex = 3;
            btnHesapAc.Text = "Hesap Aç";
            btnHesapAc.UseVisualStyleBackColor = true;
            btnHesapAc.Click += btnHesapAc_Click;
            // 
            // cmbHesapTuru
            // 
            cmbHesapTuru.FormattingEnabled = true;
            cmbHesapTuru.Location = new Point(314, 99);
            cmbHesapTuru.Name = "cmbHesapTuru";
            cmbHesapTuru.Size = new Size(456, 45);
            cmbHesapTuru.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(151, 37);
            label2.TabIndex = 0;
            label2.Text = "Hesap Türü";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 248);
            label5.Name = "label5";
            label5.Size = new Size(196, 37);
            label5.TabIndex = 0;
            label5.Text = "Ay Sonu Bakiye";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(127, 37);
            label4.TabIndex = 0;
            label4.Text = "İlk Bakiye";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(143, 37);
            label1.TabIndex = 0;
            label1.Text = "HESAP NO";
            // 
            // txtAySonuBakiye
            // 
            txtAySonuBakiye.Location = new Point(314, 248);
            txtAySonuBakiye.Name = "txtAySonuBakiye";
            txtAySonuBakiye.Size = new Size(456, 43);
            txtAySonuBakiye.TabIndex = 2;
            // 
            // txtIlkBakiye
            // 
            txtIlkBakiye.Location = new Point(314, 199);
            txtIlkBakiye.Name = "txtIlkBakiye";
            txtIlkBakiye.Size = new Size(456, 43);
            txtIlkBakiye.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(314, 150);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(456, 43);
            txtAdSoyad.TabIndex = 2;
            // 
            // txtHesapNo
            // 
            txtHesapNo.Enabled = false;
            txtHesapNo.Location = new Point(314, 50);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.Size = new Size(456, 43);
            txtHesapNo.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAySonu);
            groupBox2.Controls.Add(btnIslemYap);
            groupBox2.Controls.Add(cmbIslemTuru);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtIslemNotu);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Location = new Point(0, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 277);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "NAKİT İŞLEMLERİ";
            // 
            // btnIslemYap
            // 
            btnIslemYap.Location = new Point(544, 204);
            btnIslemYap.Name = "btnIslemYap";
            btnIslemYap.Size = new Size(226, 62);
            btnIslemYap.TabIndex = 3;
            btnIslemYap.Text = "İşlem Yap";
            btnIslemYap.UseVisualStyleBackColor = true;
            btnIslemYap.Click += btnIslemYap_Click;
            // 
            // cmbIslemTuru
            // 
            cmbIslemTuru.FormattingEnabled = true;
            cmbIslemTuru.Location = new Point(314, 55);
            cmbIslemTuru.Name = "cmbIslemTuru";
            cmbIslemTuru.Size = new Size(456, 45);
            cmbIslemTuru.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 58);
            label6.Name = "label6";
            label6.Size = new Size(139, 37);
            label6.TabIndex = 0;
            label6.Text = "İşlem Türü";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 106);
            label7.Name = "label7";
            label7.Size = new Size(78, 37);
            label7.TabIndex = 0;
            label7.Text = "Tutar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 155);
            label8.Name = "label8";
            label8.Size = new Size(146, 37);
            label8.TabIndex = 0;
            label8.Text = "İşlem Notu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 150);
            label9.Name = "label9";
            label9.Size = new Size(78, 37);
            label9.TabIndex = 0;
            label9.Text = "Tutar";
            // 
            // txtIslemNotu
            // 
            txtIslemNotu.Location = new Point(314, 155);
            txtIslemNotu.Name = "txtIslemNotu";
            txtIslemNotu.Size = new Size(456, 43);
            txtIslemNotu.TabIndex = 2;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(314, 106);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(456, 43);
            txtTutar.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblHesapHareketleri);
            groupBox3.Location = new Point(782, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(454, 587);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "HESAP HAREKETLERİ";
            // 
            // lblHesapHareketleri
            // 
            lblHesapHareketleri.Location = new Point(6, 51);
            lblHesapHareketleri.Name = "lblHesapHareketleri";
            lblHesapHareketleri.Size = new Size(442, 519);
            lblHesapHareketleri.TabIndex = 0;
            // 
            // lblSonBakiye
            // 
            lblSonBakiye.Location = new Point(788, 616);
            lblSonBakiye.Name = "lblSonBakiye";
            lblSonBakiye.Size = new Size(442, 53);
            lblSonBakiye.TabIndex = 0;
            // 
            // btnAySonu
            // 
            btnAySonu.Location = new Point(314, 204);
            btnAySonu.Name = "btnAySonu";
            btnAySonu.Size = new Size(224, 67);
            btnAySonu.TabIndex = 4;
            btnAySonu.Text = "Ay Sonu";
            btnAySonu.UseVisualStyleBackColor = true;
            btnAySonu.Click += btnAySonu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 678);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblSonBakiye);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHesapAc;
        private ComboBox cmbHesapTuru;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtAySonuBakiye;
        private TextBox txtIlkBakiye;
        private TextBox txtAdSoyad;
        private TextBox txtHesapNo;
        private GroupBox groupBox2;
        private Button btnIslemYap;
        private ComboBox cmbIslemTuru;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox txtIslemNotu;
        private TextBox txtTutar;
        private Label label7;
        private GroupBox groupBox3;
        private Label lblHesapHareketleri;
        private Label lblSonBakiye;
        private Button btnAySonu;
    }
}
