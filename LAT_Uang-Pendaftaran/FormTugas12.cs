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
    public partial class FormTugas12 : Form
    {
        public FormTugas12()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            if (radio1.Checked)
                txtHargaPendaftaran.Text = "Rp" + (0).ToString("N");
            else if (radio2.Checked)
                txtHargaPendaftaran.Text = "Rp" + (50000).ToString("N");
            else if (radio3.Checked)
                txtHargaPendaftaran.Text = "Rp" + (100000).ToString("N");
            else if (radio4.Checked)
                txtHargaPendaftaran.Text = "Rp" + (150000).ToString("N");
            else
                MessageBox.Show("Anda harus membuat pilihan");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
