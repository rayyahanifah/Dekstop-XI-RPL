namespace LAT2_Input_Data
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
            txtKtp = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNama = new TextBox();
            label4 = new Label();
            dateTanggal = new DateTimePicker();
            txtTempat = new TextBox();
            label5 = new Label();
            cmbKelamin = new ComboBox();
            label6 = new Label();
            txtAgama = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtAlamat = new RichTextBox();
            tblHapus = new Button();
            button2 = new Button();
            tblTutup1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 0;
            label1.Text = "Penginputan Data";
            // 
            // txtKtp
            // 
            txtKtp.Location = new Point(246, 63);
            txtKtp.Name = "txtKtp";
            txtKtp.Size = new Size(311, 23);
            txtKtp.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 65);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 2;
            label2.Text = "No. KTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 103);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(246, 103);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(311, 23);
            txtNama.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(92, 143);
            label4.Name = "label4";
            label4.Size = new Size(137, 17);
            label4.TabIndex = 5;
            label4.Text = "Tempat Tanggal Lahir";
            // 
            // dateTanggal
            // 
            dateTanggal.Location = new Point(357, 143);
            dateTanggal.Name = "dateTanggal";
            dateTanggal.Size = new Size(200, 23);
            dateTanggal.TabIndex = 6;
            // 
            // txtTempat
            // 
            txtTempat.Location = new Point(246, 141);
            txtTempat.Name = "txtTempat";
            txtTempat.Size = new Size(100, 23);
            txtTempat.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 181);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 8;
            label5.Text = "Jenis Kelamin";
            // 
            // cmbKelamin
            // 
            cmbKelamin.FormattingEnabled = true;
            cmbKelamin.Items.AddRange(new object[] { "Laki - Laki", "Perempuan" });
            cmbKelamin.Location = new Point(246, 179);
            cmbKelamin.Name = "cmbKelamin";
            cmbKelamin.Size = new Size(121, 23);
            cmbKelamin.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 215);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 10;
            label6.Text = "Agama";
            // 
            // txtAgama
            // 
            txtAgama.Location = new Point(246, 213);
            txtAgama.Name = "txtAgama";
            txtAgama.Size = new Size(311, 23);
            txtAgama.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(188, 250);
            label7.Name = "label7";
            label7.Size = new Size(41, 17);
            label7.TabIndex = 12;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(246, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 23);
            txtEmail.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(178, 291);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 14;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(246, 289);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(311, 86);
            txtAlamat.TabIndex = 15;
            txtAlamat.Text = "";
            // 
            // tblHapus
            // 
            tblHapus.Location = new Point(437, 388);
            tblHapus.Name = "tblHapus";
            tblHapus.Size = new Size(75, 23);
            tblHapus.TabIndex = 16;
            tblHapus.Text = "Hapus";
            tblHapus.UseVisualStyleBackColor = true;
            tblHapus.Click += tblHapus_Click;
            // 
            // button2
            // 
            button2.Location = new Point(527, 388);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Kirim";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tblTutup1
            // 
            tblTutup1.Location = new Point(166, 388);
            tblTutup1.Name = "tblTutup1";
            tblTutup1.Size = new Size(75, 23);
            tblTutup1.TabIndex = 18;
            tblTutup1.Text = "Tutup";
            tblTutup1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 438);
            Controls.Add(tblTutup1);
            Controls.Add(button2);
            Controls.Add(tblHapus);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtAgama);
            Controls.Add(label6);
            Controls.Add(cmbKelamin);
            Controls.Add(label5);
            Controls.Add(txtTempat);
            Controls.Add(dateTanggal);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtKtp);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKtp;
        private Label label2;
        private Label label3;
        private TextBox txtNama;
        private Label label4;
        private DateTimePicker dateTanggal;
        private TextBox txtTempat;
        private Label label5;
        private ComboBox cmbKelamin;
        private Label label6;
        private TextBox txtAgama;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private RichTextBox txtAlamat;
        private Button tblHapus;
        private Button button2;
        private Button tblTutup1;
    }
}
