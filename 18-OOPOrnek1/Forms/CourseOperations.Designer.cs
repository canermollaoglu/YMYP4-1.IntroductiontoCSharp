namespace _18_OOPOrnek1.Forms
{
    partial class CourseOperations
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
            button1 = new System.Windows.Forms.Button();
            dtEndDate = new System.Windows.Forms.DateTimePicker();
            dtStartDate = new System.Windows.Forms.DateTimePicker();
            txtCourseName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lstKursListesi = new System.Windows.Forms.ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtEndDate);
            groupBox1.Controls.Add(dtStartDate);
            groupBox1.Controls.Add(txtCourseName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(21, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(709, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kurs Bilgi Formu";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(432, 221);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(271, 58);
            button1.TabIndex = 3;
            button1.Text = "Kurs Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new System.Drawing.Point(263, 155);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new System.Drawing.Size(440, 43);
            dtEndDate.TabIndex = 2;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new System.Drawing.Point(263, 106);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new System.Drawing.Size(440, 43);
            dtStartDate.TabIndex = 1;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new System.Drawing.Point(263, 57);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new System.Drawing.Size(440, 43);
            txtCourseName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(0, 161);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(136, 37);
            label3.TabIndex = 0;
            label3.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(0, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(198, 37);
            label2.TabIndex = 0;
            label2.Text = "Başlangıç Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 37);
            label1.TabIndex = 0;
            label1.Text = "Kurs Adı";
            // 
            // lstKursListesi
            // 
            lstKursListesi.FormattingEnabled = true;
            lstKursListesi.ItemHeight = 37;
            lstKursListesi.Location = new System.Drawing.Point(21, 336);
            lstKursListesi.Name = "lstKursListesi";
            lstKursListesi.Size = new System.Drawing.Size(709, 263);
            lstKursListesi.TabIndex = 1;
            // 
            // CourseOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(743, 622);
            Controls.Add(lstKursListesi);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Segoe UI", 20F);
            Margin = new System.Windows.Forms.Padding(7);
            Name = "CourseOperations";
            Text = "CourseOperations";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstKursListesi;
    }
}