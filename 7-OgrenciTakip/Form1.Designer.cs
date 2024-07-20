namespace _7_OgrenciTakip
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHataMesaji = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(17, 41);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(478, 35);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 29;
            this.lstListe.Location = new System.Drawing.Point(17, 169);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(474, 120);
            this.lstListe.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "Not Ortalaması Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(17, 118);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(210, 35);
            this.txtVize.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vize Notu";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(281, 118);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(210, 35);
            this.txtFinal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Final Notu";
            // 
            // lblHataMesaji
            // 
            this.lblHataMesaji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHataMesaji.Location = new System.Drawing.Point(7, 471);
            this.lblHataMesaji.Name = "lblHataMesaji";
            this.lblHataMesaji.Size = new System.Drawing.Size(484, 56);
            this.lblHataMesaji.TabIndex = 8;
            this.lblHataMesaji.Click += new System.EventHandler(this.lblHataMesaji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 536);
            this.Controls.Add(this.lblHataMesaji);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHataMesaji;
    }
}

