namespace _18_OOPOrnek1.Forms
{
    partial class RegistrationOperations
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtKursFiyati = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cmbOgrenciler = new System.Windows.Forms.ComboBox();
            cmbKurslar = new System.Windows.Forms.ComboBox();
            btnKaydet = new System.Windows.Forms.Button();
            lstListe = new System.Windows.Forms.ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKursFiyati);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbOgrenciler);
            groupBox1.Controls.Add(cmbKurslar);
            groupBox1.Location = new System.Drawing.Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(690, 361);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt İşlemleri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 241);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 37);
            label3.TabIndex = 3;
            label3.Text = "Kurs Fiyatı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 153);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(204, 37);
            label2.TabIndex = 3;
            label2.Text = "Öğrenci Seçiniz:";
            // 
            // txtKursFiyati
            // 
            txtKursFiyati.Location = new System.Drawing.Point(40, 281);
            txtKursFiyati.Name = "txtKursFiyati";
            txtKursFiyati.Size = new System.Drawing.Size(603, 43);
            txtKursFiyati.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 37);
            label1.TabIndex = 3;
            label1.Text = "Kurs Seçiniz:";
            // 
            // cmbOgrenciler
            // 
            cmbOgrenciler.FormattingEnabled = true;
            cmbOgrenciler.Location = new System.Drawing.Point(40, 193);
            cmbOgrenciler.Name = "cmbOgrenciler";
            cmbOgrenciler.Size = new System.Drawing.Size(603, 45);
            cmbOgrenciler.TabIndex = 0;
            cmbOgrenciler.SelectedIndexChanged += cmbOgrenciler_SelectedIndexChanged;
            // 
            // cmbKurslar
            // 
            cmbKurslar.FormattingEnabled = true;
            cmbKurslar.Location = new System.Drawing.Point(40, 97);
            cmbKurslar.Name = "cmbKurslar";
            cmbKurslar.Size = new System.Drawing.Size(603, 45);
            cmbKurslar.TabIndex = 0;
            cmbKurslar.SelectedIndexChanged += cmbKurslar_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(448, 379);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(245, 48);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.Location = new System.Drawing.Point(43, 436);
            lstListe.Name = "lstListe";
            lstListe.Size = new System.Drawing.Size(650, 219);
            lstListe.TabIndex = 5;
            lstListe.UseCompatibleStateImageBehavior = false;
            lstListe.View = System.Windows.Forms.View.Details;
            // 
            // RegistrationOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(721, 667);
            Controls.Add(lstListe);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Segoe UI", 20F);
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "RegistrationOperations";
            Text = "RegistrationOperations";
            Load += RegistrationOperations_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKursFiyati;
        private System.Windows.Forms.ComboBox cmbKurslar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView lstListe;
    }
}