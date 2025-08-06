namespace LAT_Uang_Pendaftaran
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
            tblTugas12 = new Button();
            tblTugas13 = new Button();
            tblTugas14 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tblTugas12
            // 
            tblTugas12.Location = new Point(99, 106);
            tblTugas12.Name = "tblTugas12";
            tblTugas12.Size = new Size(127, 37);
            tblTugas12.TabIndex = 0;
            tblTugas12.Text = "TUGAS 12";
            tblTugas12.UseVisualStyleBackColor = true;
            tblTugas12.Click += tblTugas12_Click;
            // 
            // tblTugas13
            // 
            tblTugas13.Location = new Point(279, 106);
            tblTugas13.Name = "tblTugas13";
            tblTugas13.Size = new Size(127, 37);
            tblTugas13.TabIndex = 1;
            tblTugas13.Text = "TUGAS 13";
            tblTugas13.UseVisualStyleBackColor = true;
            tblTugas13.Click += tblTugas13_Click;
            // 
            // tblTugas14
            // 
            tblTugas14.Location = new Point(466, 106);
            tblTugas14.Name = "tblTugas14";
            tblTugas14.Size = new Size(127, 37);
            tblTugas14.TabIndex = 2;
            tblTugas14.Text = "TUGAS 14";
            tblTugas14.UseVisualStyleBackColor = true;
            tblTugas14.Click += tblTugas14_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 42);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 3;
            label1.Text = "Pilih Tugas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 186);
            Controls.Add(label1);
            Controls.Add(tblTugas14);
            Controls.Add(tblTugas13);
            Controls.Add(tblTugas12);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tblTugas12;
        private Button tblTugas13;
        private Button tblTugas14;
        private Label label1;
    }
}
