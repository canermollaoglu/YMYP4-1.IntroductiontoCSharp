namespace _11_KelimeOyunuVersion_2
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.grpKelime = new System.Windows.Forms.GroupBox();
            this.flwHarfler = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(12, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(437, 84);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Kelime Seç ve Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // grpKelime
            // 
            this.grpKelime.Location = new System.Drawing.Point(12, 102);
            this.grpKelime.Name = "grpKelime";
            this.grpKelime.Size = new System.Drawing.Size(929, 226);
            this.grpKelime.TabIndex = 1;
            this.grpKelime.TabStop = false;
            this.grpKelime.Text = "Harf Tahmin Oyunu";
            // 
            // flwHarfler
            // 
            this.flwHarfler.Location = new System.Drawing.Point(12, 351);
            this.flwHarfler.Name = "flwHarfler";
            this.flwHarfler.Size = new System.Drawing.Size(929, 306);
            this.flwHarfler.TabIndex = 2;
            // 
            // lblHak
            // 
            this.lblHak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.lblHak.Location = new System.Drawing.Point(466, 12);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(229, 84);
            this.lblHak.TabIndex = 0;
            this.lblHak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDogru
            // 
            this.lblDogru.BackColor = System.Drawing.Color.YellowGreen;
            this.lblDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.lblDogru.Location = new System.Drawing.Point(712, 12);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(229, 84);
            this.lblDogru.TabIndex = 3;
            this.lblDogru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 685);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.flwHarfler);
            this.Controls.Add(this.grpKelime);
            this.Controls.Add(this.btnBasla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.GroupBox grpKelime;
        private System.Windows.Forms.FlowLayoutPanel flwHarfler;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblDogru;
    }
}

