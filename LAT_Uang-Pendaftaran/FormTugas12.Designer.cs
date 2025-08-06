namespace LAT_Uang_Pendaftaran
{
    partial class FormTugas12
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
            label1 = new Label();
            radio1 = new RadioButton();
            radio2 = new RadioButton();
            radio3 = new RadioButton();
            radio4 = new RadioButton();
            label2 = new Label();
            tblHitung = new Button();
            txtHargaPendaftaran = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 72);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Pilih Usia ";
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio1.Location = new Point(133, 106);
            radio1.Name = "radio1";
            radio1.Size = new Size(121, 19);
            radio1.TabIndex = 1;
            radio1.TabStop = true;
            radio1.Text = "Anak (<10 Tahun)";
            radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio2.Location = new Point(133, 131);
            radio2.Name = "radio2";
            radio2.Size = new Size(139, 19);
            radio2.TabIndex = 2;
            radio2.TabStop = true;
            radio2.Text = "Remaja (10-18 Tahun)";
            radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio3.Location = new Point(133, 156);
            radio3.Name = "radio3";
            radio3.Size = new Size(143, 19);
            radio3.TabIndex = 3;
            radio3.TabStop = true;
            radio3.Text = "Dewasa (18-40 Tahun)";
            radio3.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            radio4.AutoSize = true;
            radio4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio4.Location = new Point(133, 181);
            radio4.Name = "radio4";
            radio4.Size = new Size(126, 19);
            radio4.TabIndex = 4;
            radio4.TabStop = true;
            radio4.Text = "Lanjut (>40 Tahun)";
            radio4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 24);
            label2.Name = "label2";
            label2.Size = new Size(310, 31);
            label2.TabIndex = 5;
            label2.Text = "Harga Uang Pendaftaran";
            // 
            // tblHitung
            // 
            tblHitung.BackColor = Color.FromArgb(192, 255, 255);
            tblHitung.FlatStyle = FlatStyle.Popup;
            tblHitung.Location = new Point(99, 206);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(203, 23);
            tblHitung.TabIndex = 6;
            tblHitung.Text = "Hitung ";
            tblHitung.UseVisualStyleBackColor = false;
            tblHitung.Click += tblHitung_Click;
            // 
            // txtHargaPendaftaran
            // 
            txtHargaPendaftaran.Enabled = false;
            txtHargaPendaftaran.Location = new Point(99, 235);
            txtHargaPendaftaran.Name = "txtHargaPendaftaran";
            txtHargaPendaftaran.PlaceholderText = "Harga Pendaftaran";
            txtHargaPendaftaran.Size = new Size(205, 23);
            txtHargaPendaftaran.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(229, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormTugas12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 305);
            Controls.Add(button1);
            Controls.Add(txtHargaPendaftaran);
            Controls.Add(tblHitung);
            Controls.Add(label2);
            Controls.Add(radio4);
            Controls.Add(radio3);
            Controls.Add(radio2);
            Controls.Add(radio1);
            Controls.Add(label1);
            Name = "FormTugas12";
            Text = "FormTugas12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radio1;
        private RadioButton radio2;
        private RadioButton radio3;
        private RadioButton radio4;
        private Label label2;
        private Button tblHitung;
        private TextBox txtHargaPendaftaran;
        private Button button1;
    }
}