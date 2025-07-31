namespace LAT_3_Form_Login_Menu_Perhitungan
{
    partial class FormKubus
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
            tblTutup = new Button();
            tblHapus = new Button();
            tblHitung = new Button();
            label2 = new Label();
            txtSisi = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtLuas = new TextBox();
            txtKeliling = new TextBox();
            txtVolume = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tblTutup
            // 
            tblTutup.Location = new Point(402, 159);
            tblTutup.Name = "tblTutup";
            tblTutup.Size = new Size(70, 23);
            tblTutup.TabIndex = 15;
            tblTutup.Text = "Tutup";
            tblTutup.UseVisualStyleBackColor = true;
            // 
            // tblHapus
            // 
            tblHapus.Location = new Point(316, 130);
            tblHapus.Name = "tblHapus";
            tblHapus.Size = new Size(70, 23);
            tblHapus.TabIndex = 14;
            tblHapus.Text = "Hapus";
            tblHapus.UseVisualStyleBackColor = true;
            tblHapus.Click += tblHapus_Click;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(402, 130);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(70, 23);
            tblHitung.TabIndex = 13;
            tblHitung.Text = "Hitung";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 83);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 10;
            label2.Text = "Panjang Sisi :";
            // 
            // txtSisi
            // 
            txtSisi.Location = new Point(283, 83);
            txtSisi.Name = "txtSisi";
            txtSisi.Size = new Size(80, 23);
            txtSisi.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 33);
            label1.Name = "label1";
            label1.Size = new Size(355, 31);
            label1.TabIndex = 8;
            label1.Text = "Mari Kita Menghitung Balok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 120);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 18;
            label5.Text = "Luas :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 150);
            label6.Name = "label6";
            label6.Size = new Size(61, 19);
            label6.TabIndex = 19;
            label6.Text = "Keliling :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(57, 181);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 20;
            label7.Text = "Volume :";
            // 
            // txtLuas
            // 
            txtLuas.Location = new Point(123, 120);
            txtLuas.Name = "txtLuas";
            txtLuas.Size = new Size(116, 23);
            txtLuas.TabIndex = 21;
            // 
            // txtKeliling
            // 
            txtKeliling.Location = new Point(123, 150);
            txtKeliling.Name = "txtKeliling";
            txtKeliling.Size = new Size(116, 23);
            txtKeliling.TabIndex = 22;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(123, 181);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(116, 23);
            txtVolume.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(316, 159);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 24;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormKubus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 245);
            Controls.Add(button1);
            Controls.Add(txtVolume);
            Controls.Add(txtKeliling);
            Controls.Add(txtLuas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tblTutup);
            Controls.Add(tblHapus);
            Controls.Add(tblHitung);
            Controls.Add(label2);
            Controls.Add(txtSisi);
            Controls.Add(label1);
            Name = "FormKubus";
            Text = "FormKubus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tblTutup;
        private Button tblHapus;
        private Button tblHitung;
        private Label label2;
        private TextBox txtSisi;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtLuas;
        private TextBox txtKeliling;
        private TextBox txtVolume;
        private Button button1;
    }
}