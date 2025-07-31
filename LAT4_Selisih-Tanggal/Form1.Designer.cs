namespace LAT4_Selisih_Tanggal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            date1 = new DateTimePicker();
            date2 = new DateTimePicker();
            txtSelisih = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rtbKeterangan = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            tblHasil = new Button();
            tblHapus = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 23);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 0;
            label1.Text = "Selisih Dua Tanggal";
            // 
            // date1
            // 
            date1.Location = new Point(71, 90);
            date1.Name = "date1";
            date1.Size = new Size(200, 23);
            date1.TabIndex = 1;
            // 
            // date2
            // 
            date2.Location = new Point(293, 90);
            date2.Name = "date2";
            date2.Size = new Size(200, 23);
            date2.TabIndex = 2;
            // 
            // txtSelisih
            // 
            txtSelisih.Location = new Point(164, 130);
            txtSelisih.Name = "txtSelisih";
            txtSelisih.Size = new Size(229, 23);
            txtSelisih.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 130);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 4;
            label2.Text = "Selisih";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 164);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 5;
            label3.Text = "Keterangan";
            // 
            // rtbKeterangan
            // 
            rtbKeterangan.Location = new Point(164, 164);
            rtbKeterangan.Name = "rtbKeterangan";
            rtbKeterangan.Size = new Size(229, 96);
            rtbKeterangan.TabIndex = 6;
            rtbKeterangan.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 68);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 7;
            label4.Text = "Tanggal Pertama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(293, 68);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 8;
            label5.Text = "Tanggal Kedua";
            // 
            // tblHasil
            // 
            tblHasil.Location = new Point(418, 130);
            tblHasil.Name = "tblHasil";
            tblHasil.Size = new Size(75, 23);
            tblHasil.TabIndex = 9;
            tblHasil.Text = "Hasil";
            tblHasil.UseVisualStyleBackColor = true;
            tblHasil.Click += tblHasil_Click;
            // 
            // tblHapus
            // 
            tblHapus.Location = new Point(418, 164);
            tblHapus.Name = "tblHapus";
            tblHapus.Size = new Size(75, 23);
            tblHapus.TabIndex = 10;
            tblHapus.Text = "Hapus";
            tblHapus.UseVisualStyleBackColor = true;
            tblHapus.Click += tblHapus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 299);
            Controls.Add(tblHapus);
            Controls.Add(tblHasil);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rtbKeterangan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSelisih);
            Controls.Add(date2);
            Controls.Add(date1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker date1;
        private DateTimePicker date2;
        private TextBox txtSelisih;
        private Label label2;
        private Label label3;
        private RichTextBox rtbKeterangan;
        private Label label4;
        private Label label5;
        private Button tblHasil;
        private Button tblHapus;
    }
}
