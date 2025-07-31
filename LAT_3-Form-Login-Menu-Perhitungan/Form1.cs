using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace LAT_3_Form_Login_Menu_Perhitungan
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void tblLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
