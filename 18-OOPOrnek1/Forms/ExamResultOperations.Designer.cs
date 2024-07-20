namespace _18_OOPOrnek1.Forms
{
    partial class ExamResultOperations
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
            nmrNot = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cmbSinavlar = new System.Windows.Forms.ComboBox();
            cmbOgrenciler = new System.Windows.Forms.ComboBox();
            btnKaydet = new System.Windows.Forms.Button();
            lstListe = new System.Windows.Forms.ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrNot).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nmrNot);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbSinavlar);
            groupBox1.Controls.Add(cmbOgrenciler);
            groupBox1.Location = new System.Drawing.Point(22, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(996, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınav Sonuç Giriş Ekranı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 281);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 37);
            label3.TabIndex = 3;
            label3.Text = "Sınav Notu:";
            // 
            // nmrNot
            // 
            nmrNot.Location = new System.Drawing.Point(183, 279);
            nmrNot.Name = "nmrNot";
            nmrNot.Size = new System.Drawing.Size(218, 43);
            nmrNot.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 170);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 37);
            label2.TabIndex = 1;
            label2.Text = "Sınav Seçiniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 37);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci Seçiniz:";
            // 
            // cmbSinavlar
            // 
            cmbSinavlar.FormattingEnabled = true;
            cmbSinavlar.Location = new System.Drawing.Point(6, 216);
            cmbSinavlar.Name = "cmbSinavlar";
            cmbSinavlar.Size = new System.Drawing.Size(669, 45);
            cmbSinavlar.TabIndex = 0;
            cmbSinavlar.SelectedIndexChanged += cmbSinavlar_SelectedIndexChanged;
            // 
            // cmbOgrenciler
            // 
            cmbOgrenciler.FormattingEnabled = true;
            cmbOgrenciler.Location = new System.Drawing.Point(6, 111);
            cmbOgrenciler.Name = "cmbOgrenciler";
            cmbOgrenciler.Size = new System.Drawing.Size(669, 45);
            cmbOgrenciler.TabIndex = 0;
            cmbOgrenciler.SelectedIndexChanged += cmbOgrenciler_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(699, 396);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(319, 62);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new System.Drawing.Point(12, 477);
            lstListe.Name = "lstListe";
            lstListe.Size = new System.Drawing.Size(1006, 263);
            lstListe.TabIndex = 2;
            // 
            // ExamResultOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1030, 765);
            Controls.Add(lstListe);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Segoe UI", 20F);
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "ExamResultOperations";
            Text = "ExamResultOperations";
            Load += ExamResultOperations_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrNot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSinavlar;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstListe;
    }
}