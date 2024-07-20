namespace _4.Donguler
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
            this.btnBul = new System.Windows.Forms.Button();
            this.txtCumle = new System.Windows.Forms.TextBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnDiziAra = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(455, 211);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(195, 52);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "Arama Yap";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtCumle
            // 
            this.txtCumle.AcceptsReturn = true;
            this.txtCumle.Location = new System.Drawing.Point(17, 170);
            this.txtCumle.Name = "txtCumle";
            this.txtCumle.Size = new System.Drawing.Size(633, 35);
            this.txtCumle.TabIndex = 1;
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(17, 64);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(192, 35);
            this.txtAranan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranan Harf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arama Cümlesi";
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(249, 23);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(188, 90);
            this.lblSonuc.TabIndex = 4;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(214, 214);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(235, 49);
            this.btnDegistir.TabIndex = 5;
            this.btnDegistir.Text = "Bul ve Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnDiziAra
            // 
            this.btnDiziAra.Location = new System.Drawing.Point(214, 269);
            this.btnDiziAra.Name = "btnDiziAra";
            this.btnDiziAra.Size = new System.Drawing.Size(436, 41);
            this.btnDiziAra.TabIndex = 6;
            this.btnDiziAra.Text = "Dizide Arama Yap";
            this.btnDiziAra.UseVisualStyleBackColor = true;
            this.btnDiziAra.Click += new System.EventHandler(this.btnDiziAra_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 29;
            this.lstListe.Location = new System.Drawing.Point(681, 8);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(203, 294);
            this.lstListe.TabIndex = 7;
            // 
            // Ornek1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 346);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnDiziAra);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.txtCumle);
            this.Controls.Add(this.btnBul);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Ornek1";
            this.Text = "Ornek1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtCumle;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnDiziAra;
        private System.Windows.Forms.ListBox lstListe;
    }
}