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
            txtPassword = new TextBox();
            tblLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 38);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(69, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(178, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(69, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 4;
            // 
            // tblLogin
            // 
            tblLogin.BackColor = Color.FromArgb(192, 255, 192);
            tblLogin.FlatStyle = FlatStyle.Popup;
            tblLogin.Location = new Point(69, 162);
            tblLogin.Name = "tblLogin";
            tblLogin.Size = new Size(178, 27);
            tblLogin.TabIndex = 5;
            tblLogin.Text = "Masuk";
            tblLogin.UseVisualStyleBackColor = false;
            tblLogin.Click += tblLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 246);
            Controls.Add(tblLogin);
            Controls.Add(txtPassword);
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
        private TextBox txtPassword;
        private Button tblLogin;
    }
}
