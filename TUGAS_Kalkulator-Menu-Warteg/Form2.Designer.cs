namespace TUGAS_Kalkulator_Menu_Warteg
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
            label1 = new Label();
            label5 = new Label();
            lblNama = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txtTotal = new TextBox();
            txtPajak = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtHarga = new TextBox();
            listBoxPesanan = new ListBox();
            tblKembali = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 23);
            label1.Name = "label1";
            label1.Size = new Size(235, 36);
            label1.TabIndex = 1;
            label1.Text = "Warteg Modern";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 74);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 15;
            label5.Text = "Nama :";
            // 
            // lblNama
            // 
            lblNama.Enabled = false;
            lblNama.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(128, 71);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(121, 26);
            lblNama.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 106);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 17;
            label2.Text = "Detail Pesanan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(69, 394);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 26;
            label6.Text = "Total :";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(128, 391);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 26);
            txtTotal.TabIndex = 25;
            // 
            // txtPajak
            // 
            txtPajak.Enabled = false;
            txtPajak.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPajak.Location = new Point(128, 359);
            txtPajak.Name = "txtPajak";
            txtPajak.Size = new Size(121, 26);
            txtPajak.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(69, 362);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 23;
            label7.Text = "Pajak :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F);
            label8.Location = new Point(69, 330);
            label8.Name = "label8";
            label8.Size = new Size(53, 19);
            label8.TabIndex = 21;
            label8.Text = "Harga :";
            // 
            // txtHarga
            // 
            txtHarga.Enabled = false;
            txtHarga.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHarga.Location = new Point(128, 327);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(121, 26);
            txtHarga.TabIndex = 22;
            // 
            // listBoxPesanan
            // 
            listBoxPesanan.FormattingEnabled = true;
            listBoxPesanan.ItemHeight = 15;
            listBoxPesanan.Location = new Point(69, 128);
            listBoxPesanan.Name = "listBoxPesanan";
            listBoxPesanan.Size = new Size(180, 184);
            listBoxPesanan.TabIndex = 27;
            // 
            // tblKembali
            // 
            tblKembali.FlatStyle = FlatStyle.Popup;
            tblKembali.Location = new Point(197, 434);
            tblKembali.Name = "tblKembali";
            tblKembali.Size = new Size(75, 23);
            tblKembali.TabIndex = 28;
            tblKembali.Text = "Kembali";
            tblKembali.UseVisualStyleBackColor = true;
            tblKembali.Click += tblKembali_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 483);
            Controls.Add(tblKembali);
            Controls.Add(listBoxPesanan);
            Controls.Add(label6);
            Controls.Add(txtTotal);
            Controls.Add(txtPajak);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtHarga);
            Controls.Add(label2);
            Controls.Add(lblNama);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox lblNama;
        private Label label2;
        private Label label6;
        private TextBox txtTotal;
        private TextBox txtPajak;
        private Label label7;
        private Label label8;
        private TextBox txtHarga;
        private ListBox listBoxPesanan;
        private Button tblKembali;
    }
}