namespace LAT_3_Form_Login_Menu_Perhitungan
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
            txtUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            tblLogin = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 42);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 0;
            label1.Text = "Form Login";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(187, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(132, 23);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 94);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 128);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(187, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(132, 23);
            txtPassword.TabIndex = 4;
            // 
            // tblLogin
            // 
            tblLogin.Location = new Point(266, 170);
            tblLogin.Name = "tblLogin";
            tblLogin.Size = new Size(53, 23);
            tblLogin.TabIndex = 5;
            tblLogin.Text = "Login";
            tblLogin.UseVisualStyleBackColor = true;
            tblLogin.Click += tblLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(203, 170);
            button1.Name = "button1";
            button1.Size = new Size(57, 23);
            button1.TabIndex = 6;
            button1.Text = "Hapus";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 170);
            button2.Name = "button2";
            button2.Size = new Size(57, 23);
            button2.TabIndex = 7;
            button2.Text = "Tutup";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 246);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tblLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button tblLogin;
        private Button button1;
        private Button button2;
    }
}
