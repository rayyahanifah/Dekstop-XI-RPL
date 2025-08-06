namespace LAT_Uang_Pendaftaran
{
    partial class FormTugas13
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
            txtTotal = new TextBox();
            tblHitung = new Button();
            label2 = new Label();
            CB1 = new CheckBox();
            CB2 = new CheckBox();
            CB3 = new CheckBox();
            CB4 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(104, 219);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "Total Biaya Keseatan";
            txtTotal.Size = new Size(205, 23);
            txtTotal.TabIndex = 15;
            // 
            // tblHitung
            // 
            tblHitung.BackColor = Color.FromArgb(192, 255, 255);
            tblHitung.FlatStyle = FlatStyle.Popup;
            tblHitung.Location = new Point(104, 190);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(203, 23);
            tblHitung.TabIndex = 14;
            tblHitung.Text = "Hitung ";
            tblHitung.UseVisualStyleBackColor = false;
            tblHitung.Click += tblHitung_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 33);
            label2.Name = "label2";
            label2.Size = new Size(211, 31);
            label2.TabIndex = 13;
            label2.Text = "Biaya Kesehatan";
            // 
            // CB1
            // 
            CB1.AutoSize = true;
            CB1.Font = new Font("Times New Roman", 12F);
            CB1.Location = new Point(113, 76);
            CB1.Name = "CB1";
            CB1.Size = new Size(174, 23);
            CB1.TabIndex = 16;
            CB1.Text = "Pembelian Obat Obatan";
            CB1.UseVisualStyleBackColor = true;
            // 
            // CB2
            // 
            CB2.AutoSize = true;
            CB2.Font = new Font("Times New Roman", 12F);
            CB2.Location = new Point(113, 105);
            CB2.Name = "CB2";
            CB2.Size = new Size(133, 23);
            CB2.TabIndex = 17;
            CB2.Text = "Pemeriksaan Gigi";
            CB2.UseVisualStyleBackColor = true;
            // 
            // CB3
            // 
            CB3.AutoSize = true;
            CB3.Font = new Font("Times New Roman", 12F);
            CB3.Location = new Point(113, 132);
            CB3.Name = "CB3";
            CB3.Size = new Size(141, 23);
            CB3.TabIndex = 18;
            CB3.Text = "Pemeriksaan Mata";
            CB3.UseVisualStyleBackColor = true;
            // 
            // CB4
            // 
            CB4.AutoSize = true;
            CB4.Font = new Font("Times New Roman", 12F);
            CB4.Location = new Point(113, 161);
            CB4.Name = "CB4";
            CB4.Size = new Size(191, 23);
            CB4.TabIndex = 19;
            CB4.Text = "Pemeriksaan Laboratorium";
            CB4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(235, 253);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormTugas13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 310);
            Controls.Add(button1);
            Controls.Add(CB4);
            Controls.Add(CB3);
            Controls.Add(CB2);
            Controls.Add(CB1);
            Controls.Add(txtTotal);
            Controls.Add(tblHitung);
            Controls.Add(label2);
            Name = "FormTugas13";
            Text = "FormTugas13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button tblHitung;
        private Label label2;
        private CheckBox CB1;
        private CheckBox CB2;
        private CheckBox CB3;
        private CheckBox CB4;
        private Button button1;
    }
}