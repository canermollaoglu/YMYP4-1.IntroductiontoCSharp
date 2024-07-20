namespace _12_Ado.Net
{
    partial class Form2
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUrunListesi = new System.Windows.Forms.ListBox();
            this.dgwSiparisDetay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(19, 49);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(326, 45);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Seçiniz";
            // 
            // lstUrunListesi
            // 
            this.lstUrunListesi.FormattingEnabled = true;
            this.lstUrunListesi.ItemHeight = 37;
            this.lstUrunListesi.Location = new System.Drawing.Point(19, 182);
            this.lstUrunListesi.Name = "lstUrunListesi";
            this.lstUrunListesi.Size = new System.Drawing.Size(326, 300);
            this.lstUrunListesi.TabIndex = 2;
            this.lstUrunListesi.SelectedIndexChanged += new System.EventHandler(this.lstUrunListesi_SelectedIndexChanged);
            // 
            // dgwSiparisDetay
            // 
            this.dgwSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSiparisDetay.Location = new System.Drawing.Point(351, 182);
            this.dgwSiparisDetay.Name = "dgwSiparisDetay";
            this.dgwSiparisDetay.Size = new System.Drawing.Size(663, 300);
            this.dgwSiparisDetay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sipariş Detayları";
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(351, 49);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(178, 37);
            this.lblUrunAdet.TabIndex = 1;
            this.lblUrunAdet.Text = "Ürün Adedi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 506);
            this.Controls.Add(this.dgwSiparisDetay);
            this.Controls.Add(this.lstUrunListesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUrunAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparisDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstUrunListesi;
        private System.Windows.Forms.DataGridView dgwSiparisDetay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUrunAdet;
    }
}