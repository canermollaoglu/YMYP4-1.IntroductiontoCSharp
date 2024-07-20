namespace _18_OOPOrnek1.Forms
{
    partial class LessonOperations
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
            dtDate = new System.Windows.Forms.DateTimePicker();
            nmrDuration = new System.Windows.Forms.NumericUpDown();
            txtContent = new System.Windows.Forms.TextBox();
            txtTitle = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cmbCourses = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            lstList = new System.Windows.Forms.ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrDuration).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtDate);
            groupBox1.Controls.Add(nmrDuration);
            groupBox1.Controls.Add(txtContent);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F);
            groupBox1.Location = new System.Drawing.Point(22, 137);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(773, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Atama Formu";
            // 
            // dtDate
            // 
            dtDate.Location = new System.Drawing.Point(174, 378);
            dtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtDate.Name = "dtDate";
            dtDate.Size = new System.Drawing.Size(582, 39);
            dtDate.TabIndex = 3;
            // 
            // nmrDuration
            // 
            nmrDuration.Location = new System.Drawing.Point(174, 325);
            nmrDuration.Name = "nmrDuration";
            nmrDuration.Size = new System.Drawing.Size(133, 39);
            nmrDuration.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.Location = new System.Drawing.Point(174, 126);
            txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(582, 191);
            txtContent.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(174, 77);
            txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(582, 39);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 130);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 32);
            label2.TabIndex = 0;
            label2.Text = "Ders İçeriği";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 371);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(125, 32);
            label4.TabIndex = 0;
            label4.Text = "Ders Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 325);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 32);
            label3.TabIndex = 0;
            label3.Text = "Süresi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 77);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 32);
            label1.TabIndex = 0;
            label1.Text = "Ders Başlığı";
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new System.Drawing.Point(23, 71);
            cmbCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new System.Drawing.Size(772, 40);
            cmbCourses.TabIndex = 1;
            cmbCourses.SelectedIndexChanged += cmbCourses_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label5.Location = new System.Drawing.Point(22, 24);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(444, 29);
            label5.TabIndex = 4;
            label5.Text = "Lütfen Ders Atamak için Bir Kurs Seçiniz:";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(564, 591);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(231, 48);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kursa Ders Ata";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 32;
            lstList.Location = new System.Drawing.Point(819, 71);
            lstList.Name = "lstList";
            lstList.Size = new System.Drawing.Size(451, 548);
            lstList.TabIndex = 6;
            // 
            // LessonOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1280, 646);
            Controls.Add(lstList);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(cmbCourses);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Segoe UI", 18F);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "LessonOperations";
            Text = "LessonOperations";
            Load += LessonOperations_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.NumericUpDown nmrDuration;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstList;
    }
}