using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LAT_Uang_Pendaftaran
{
    public partial class FormTugas14 : Form
    {
        static int jum = 0;

        public FormTugas14()
        {
            InitializeComponent();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB1.Checked)
                jum += 350000;
            else
                jum -= 350000;
            txtTotal.Text = "Rp" + jum.ToString("N");
        }

        private void CB2_CheckedChanged(object sender, EventArgs e)
        {
            if (CB2.Checked)
                jum += 450000;
            else
                jum -= 450000;
            txtTotal.Text = "Rp" + jum.ToString("N");
        }

        private void CB3_CheckedChanged(object sender, EventArgs e)
        {
            if (CB3.Checked)
                jum += 550000;
            else
                jum -= 550000;
            txtTotal.Text = "Rp" + jum.ToString("N");
        }

        private void CB4_CheckedChanged(object sender, EventArgs e)
        {
            if (CB4.Checked)
                jum += 250000;
            else
                jum -= 250000;
            txtTotal.Text = "Rp" + jum.ToString("N");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
