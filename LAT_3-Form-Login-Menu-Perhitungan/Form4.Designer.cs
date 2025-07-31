namespace LAT_3_Form_Login_Menu_Perhitungan
{
    partial class Form4
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
            button1 = new Button();
            txtVolume = new TextBox();
            txtKeliling = new TextBox();
            txtLuas = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tblTutup = new Button();
            tblHapus = new Button();
            tblHitung = new Button();
            label2 = new Label();
            txtJariJari = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(316, 160);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 37;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(123, 182);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(116, 23);
            txtVolume.TabIndex = 36;
            // 
            // txtKeliling
            // 
            txtKeliling.Location = new Point(123, 151);
            txtKeliling.Name = "txtKeliling";
            txtKeliling.Size = new Size(116, 23);
            txtKeliling.TabIndex = 35;
            // 
            // txtLuas
            // 
            txtLuas.Location = new Point(123, 121);
            txtLuas.Name = "txtLuas";
            txtLuas.Size = new Size(116, 23);
            txtLuas.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(57, 182);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 33;
            label7.Text = "Volume :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 151);
            label6.Name = "label6";
            label6.Size = new Size(61, 19);
            label6.TabIndex = 32;
            label6.Text = "Keliling :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 121);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 31;
            label5.Text = "Luas :";
            // 
            // tblTutup
            // 
            tblTutup.Location = new Point(402, 160);
            tblTutup.Name = "tblTutup";
            tblTutup.Size = new Size(70, 23);
            tblTutup.TabIndex = 30;
            tblTutup.Text = "Tutup";
            tblTutup.UseVisualStyleBackColor = true;
            tblTutup.Click += tblTutup_Click;
            // 
            // tblHapus
            // 
            tblHapus.Location = new Point(316, 131);
            tblHapus.Name = "tblHapus";
            tblHapus.Size = new Size(70, 23);
            tblHapus.TabIndex = 29;
            tblHapus.Text = "Hapus";
            tblHapus.UseVisualStyleBackColor = true;
            tblHapus.Click += tblHapus_Click;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(402, 131);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(70, 23);
            tblHitung.TabIndex = 28;
            tblHitung.Text = "Hitung";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 84);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 27;
            label2.Text = "Panjang Jari Jari :";
            // 
            // txtJariJari
            // 
            txtJariJari.Location = new Point(270, 80);
            txtJariJari.Name = "txtJariJari";
            txtJariJari.Size = new Size(80, 23);
            txtJariJari.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 34);
            label1.Name = "label1";
            label1.Size = new Size(340, 31);
            label1.TabIndex = 25;
            label1.Text = "Mari Kita Menghitung Bola";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 254);
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
            Controls.Add(txtJariJari);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtVolume;
        private TextBox txtKeliling;
        private TextBox txtLuas;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button tblTutup;
        private Button tblHapus;
        private Button tblHitung;
        private Label label2;
        private TextBox txtJariJari;
        private Label label1;
    }
}