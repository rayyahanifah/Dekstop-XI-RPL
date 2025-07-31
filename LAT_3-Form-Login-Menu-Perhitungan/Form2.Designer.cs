namespace LAT_3_Form_Login_Menu_Perhitungan
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
            txtKubus = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 30);
            label1.Name = "label1";
            label1.Size = new Size(298, 26);
            label1.TabIndex = 1;
            label1.Text = "Menghitung Apa Hari Ini??";
            // 
            // txtKubus
            // 
            txtKubus.Location = new Point(38, 88);
            txtKubus.Name = "txtKubus";
            txtKubus.Size = new Size(176, 42);
            txtKubus.TabIndex = 2;
            txtKubus.Text = "Kubus";
            txtKubus.UseVisualStyleBackColor = true;
            txtKubus.Click += txtKubus_Click;
            // 
            // button2
            // 
            button2.Location = new Point(38, 150);
            button2.Name = "button2";
            button2.Size = new Size(176, 42);
            button2.TabIndex = 3;
            button2.Text = "Balok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(140, 208);
            button3.Name = "button3";
            button3.Size = new Size(176, 42);
            button3.TabIndex = 4;
            button3.Text = "Limas Segi Empat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(245, 88);
            button4.Name = "button4";
            button4.Size = new Size(176, 42);
            button4.TabIndex = 5;
            button4.Text = "Bola";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(245, 150);
            button5.Name = "button5";
            button5.Size = new Size(176, 42);
            button5.TabIndex = 6;
            button5.Text = "Tabung";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 295);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtKubus);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button txtKubus;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}