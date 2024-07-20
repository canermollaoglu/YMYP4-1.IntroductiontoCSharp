namespace _10_KelimeOyunuVersion_1
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
            this.btnOyna = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHarfler = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(523, 96);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(145, 45);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Tag = "";
            this.btnOyna.Text = "OYNA";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(27, 55);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(641, 35);
            this.txtKelime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen bir kelime giriniz:";
            // 
            // grpHarfler
            // 
            this.grpHarfler.Location = new System.Drawing.Point(27, 163);
            this.grpHarfler.Name = "grpHarfler";
            this.grpHarfler.Size = new System.Drawing.Size(890, 266);
            this.grpHarfler.TabIndex = 3;
            this.grpHarfler.TabStop = false;
            this.grpHarfler.Text = "Harf Tahmini";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 469);
            this.Controls.Add(this.grpHarfler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.btnOyna);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpHarfler;
    }
}

