namespace LAT3_Kalkulator_Combobox
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
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            cmbOperasi = new ComboBox();
            label2 = new Label();
            txtHasil = new TextBox();
            tblHasil = new Button();
            tblHapus = new Button();
            History = new ListBox();
            tblHapusHistory = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 34);
            label1.Name = "label1";
            label1.Size = new Size(283, 24);
            label1.TabIndex = 0;
            label1.Text = "Kalkulator Dengan Combobox";
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(69, 90);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(100, 23);
            txtInput1.TabIndex = 1;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(256, 90);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(100, 23);
            txtInput2.TabIndex = 2;
            // 
            // cmbOperasi
            // 
            cmbOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperasi.FormattingEnabled = true;
            cmbOperasi.Items.AddRange(new object[] { "+", "-", "*", "/", "" });
            cmbOperasi.Location = new Point(187, 90);
            cmbOperasi.Name = "cmbOperasi";
            cmbOperasi.Size = new Size(51, 23);
            cmbOperasi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 90);
            label2.Name = "label2";
            label2.Size = new Size(22, 24);
            label2.TabIndex = 4;
            label2.Text = "=";
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(390, 90);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(100, 23);
            txtHasil.TabIndex = 5;
            // 
            // tblHasil
            // 
            tblHasil.Location = new Point(407, 127);
            tblHasil.Name = "tblHasil";
            tblHasil.Size = new Size(83, 24);
            tblHasil.TabIndex = 6;
            tblHasil.Text = "Hitung";
            tblHasil.UseVisualStyleBackColor = true;
            tblHasil.Click += tblHasil_Click;
            // 
            // tblHapus
            // 
            tblHapus.Location = new Point(318, 127);
            tblHapus.Name = "tblHapus";
            tblHapus.Size = new Size(83, 24);
            tblHapus.TabIndex = 7;
            tblHapus.Text = "Hapus";
            tblHapus.UseVisualStyleBackColor = true;
            tblHapus.Click += tblHapus_Click;
            // 
            // History
            // 
            History.FormattingEnabled = true;
            History.ItemHeight = 15;
            History.Location = new Point(69, 154);
            History.Name = "History";
            History.Size = new Size(243, 184);
            History.TabIndex = 8;
            History.SelectedIndexChanged += History_SelectedIndexChanged;
            // 
            // tblHapusHistory
            // 
            tblHapusHistory.Location = new Point(211, 306);
            tblHapusHistory.Name = "tblHapusHistory";
            tblHapusHistory.Size = new Size(91, 23);
            tblHapusHistory.TabIndex = 9;
            tblHapusHistory.Text = "Hapus History";
            tblHapusHistory.UseVisualStyleBackColor = true;
            tblHapusHistory.Click += tblHapusHistoryg  _Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 136);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 10;
            label3.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 368);
            Controls.Add(label3);
            Controls.Add(tblHapusHistory);
            Controls.Add(History);
            Controls.Add(tblHapus);
            Controls.Add(tblHasil);
            Controls.Add(txtHasil);
            Controls.Add(label2);
            Controls.Add(cmbOperasi);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput1;
        private TextBox txtInput2;
        private ComboBox cmbOperasi;
        private Label label2;
        private TextBox txtHasil;
        private Button tblHasil;
        private Button tblHapus;
        private ListBox History;
        private Button tblHapusHistory;
        private Label label3;
    }
}
