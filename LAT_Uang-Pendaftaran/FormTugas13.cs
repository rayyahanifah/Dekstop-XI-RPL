using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAT_Uang_Pendaftaran
{
    public partial class FormTugas13 : Form
    {
        public FormTugas13()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            int jum = 0;
            if (CB1.Checked)
                jum += 350000;
            if (CB2.Checked)
                jum += 450000;
            if (CB3.Checked)
                jum += 550000;
            if (CB4.Checked)
                jum += 250000;
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
