namespace LAT1_Hitung_Nilai_Rata_Rata
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
            txtNilaiHarian = new TextBox();
            txtNilaiTengah = new TextBox();
            txtNilaiAkhir = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNilaiRata = new TextBox();
            txtKeterangan = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tblHapus = new Button();
            tblHitung = new Button();
            tblTutup = new Button();
            txtKategori = new TextBox();
            label7 = new Label();
            txtSimpan = new Button();
            SuspendLayout();
            // 
            // txtNilaiHarian
            // 
            txtNilaiHarian.Location = new Point(38, 119);
            txtNilaiHarian.Name = "txtNilaiHarian";
            txtNilaiHarian.Size = new Size(100, 23);
            txtNilaiHarian.TabIndex = 0;
            // 
            // txtNilaiTengah
            // 
            txtNilaiTengah.Location = new Point(161, 119);
            txtNilaiTengah.Name = "txtNilaiTengah";
            txtNilaiTengah.Size = new Size(100, 23);
            txtNilaiTengah.TabIndex = 1;
            // 
            // txtNilaiAkhir
            // 
            txtNilaiAkhir.Location = new Point(283, 119);
            txtNilaiAkhir.Name = "txtNilaiAkhir";
            txtNilaiAkhir.Size = new Size(100, 23);
            txtNilaiAkhir.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 90);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Nilai Harian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 90);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "Nilai Akhir Semester";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 90);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 5;
            label3.Text = "Nilai Tengah Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 46);
            label4.Name = "label4";
            label4.Size = new Size(261, 24);
            label4.TabIndex = 6;
            label4.Text = "Menghitung Nilai Rata Rata";
            // 
            // txtNilaiRata
            // 
            txtNilaiRata.Location = new Point(38, 187);
            txtNilaiRata.Name = "txtNilaiRata";
            txtNilaiRata.Size = new Size(100, 23);
            txtNilaiRata.TabIndex = 7;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(283, 187);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(121, 23);
            txtKeterangan.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 169);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 9;
            label5.Text = "Nilai Rata Rata";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 169);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 10;
            label6.Text = "Keterangan";
            // 
            // tblHapus
            // 
            tblHapus.Location = new Point(418, 100);
            tblHapus.Name = "tblHapus";
            tblHapus.Size = new Size(75, 23);
            tblHapus.TabIndex = 11;
            tblHapus.Text = "HAPUS";
            tblHapus.UseVisualStyleBackColor = true;
            tblHapus.Click += tblHapus_Click;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(418, 129);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(75, 23);
            tblHitung.TabIndex = 12;
            tblHitung.Text = "HITUNG";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // tblTutup
            // 
            tblTutup.Location = new Point(418, 158);
            tblTutup.Name = "tblTutup";
            tblTutup.Size = new Size(75, 23);
            tblTutup.TabIndex = 13;
            tblTutup.Text = "TUTUP";
            tblTutup.UseVisualStyleBackColor = true;
            tblTutup.Click += tblTutup_Click;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(183, 187);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(51, 23);
            txtKategori.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 169);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 15;
            label7.Text = "Kategori";
            // 
            // txtSimpan
            // 
            txtSimpan.Location = new Point(418, 187);
            txtSimpan.Name = "txtSimpan";
            txtSimpan.Size = new Size(75, 23);
            txtSimpan.TabIndex = 16;
            txtSimpan.Text = "SIMPAN";
            txtSimpan.UseVisualStyleBackColor = true;
            txtSimpan.Click += txtSimpan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 271);
            Controls.Add(txtSimpan);
            Controls.Add(label7);
            Controls.Add(txtKategori);
            Controls.Add(tblTutup);
            Controls.Add(tblHitung);
            Controls.Add(tblHapus);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtKeterangan);
            Controls.Add(txtNilaiRata);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNilaiAkhir);
            Controls.Add(txtNilaiTengah);
            Controls.Add(txtNilaiHarian);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNilaiHarian;
        private TextBox txtNilaiTengah;
        private TextBox txtNilaiAkhir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNilaiRata;
        private TextBox txtKeterangan;
        private Label label5;
        private Label label6;
        private Button tblHapus;
        private Button tblHitung;
        private Button tblTutup;
        private TextBox txtKategori;
        private Label label7;
        private Button txtSimpan;
    }
}
