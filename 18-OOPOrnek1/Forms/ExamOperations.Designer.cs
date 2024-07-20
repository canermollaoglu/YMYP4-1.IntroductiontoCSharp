namespace _18_OOPOrnek1.Forms
{
    partial class ExamOperations
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
            grpSinavBilgileri = new System.Windows.Forms.GroupBox();
            dtSinavTarihi = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtSinavAdi = new System.Windows.Forms.TextBox();
            btnKaydet = new System.Windows.Forms.Button();
            lstList = new System.Windows.Forms.ListBox();
            grpSinavBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // grpSinavBilgileri
            // 
            grpSinavBilgileri.Controls.Add(dtSinavTarihi);
            grpSinavBilgileri.Controls.Add(label2);
            grpSinavBilgileri.Controls.Add(label1);
            grpSinavBilgileri.Controls.Add(txtSinavAdi);
            grpSinavBilgileri.Location = new System.Drawing.Point(0, 0);
            grpSinavBilgileri.Name = "grpSinavBilgileri";
            grpSinavBilgileri.Size = new System.Drawing.Size(698, 193);
            grpSinavBilgileri.TabIndex = 0;
            grpSinavBilgileri.TabStop = false;
            grpSinavBilgileri.Text = "Sınav Bilgileri";
            // 
            // dtSinavTarihi
            // 
            dtSinavTarihi.Location = new System.Drawing.Point(244, 110);
            dtSinavTarihi.Name = "dtSinavTarihi";
            dtSinavTarihi.Size = new System.Drawing.Size(448, 47);
            dtSinavTarihi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(164, 41);
            label2.TabIndex = 0;
            label2.Text = "Sınav Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 41);
            label1.TabIndex = 0;
            label1.Text = "Sınav Adı";
            // 
            // txtSinavAdi
            // 
            txtSinavAdi.Location = new System.Drawing.Point(244, 46);
            txtSinavAdi.Name = "txtSinavAdi";
            txtSinavAdi.Size = new System.Drawing.Size(448, 47);
            txtSinavAdi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(408, 199);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(290, 53);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 40;
            lstList.Location = new System.Drawing.Point(12, 257);
            lstList.Name = "lstList";
            lstList.Size = new System.Drawing.Size(686, 204);
            lstList.TabIndex = 2;
            lstList.SelectedIndexChanged += lstList_SelectedIndexChanged;
            // 
            // ExamOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(710, 499);
            Controls.Add(lstList);
            Controls.Add(btnKaydet);
            Controls.Add(grpSinavBilgileri);
            Font = new System.Drawing.Font("Segoe UI", 22F);
            Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            Name = "ExamOperations";
            Text = "ExamOperations";
            grpSinavBilgileri.ResumeLayout(false);
            grpSinavBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSinavBilgileri;
        private System.Windows.Forms.DateTimePicker dtSinavTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinavAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstList;
    }
}