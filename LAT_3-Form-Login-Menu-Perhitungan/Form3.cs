using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAT_3_Form_Login_Menu_Perhitungan
{
    public partial class FormKubus : Form
    {
        public FormKubus()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            double sisi;

            if (double.TryParse(txtSisi.Text, out sisi))
            {
                double luas = 6 * sisi * sisi;
                double keliling = 12 * sisi;
                double volume = sisi * sisi * sisi;

                txtLuas.Text = luas.ToString();
                txtKeliling.Text = keliling.ToString();
                txtVolume.Text = volume.ToString();
            }
            else
            {
                MessageBox.Show("Masukkan angka valid untuk panjang sisi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtKeliling.Clear();
            txtLuas.Clear();
            txtSisi.Clear();
            txtVolume.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void tblTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void tblTutup_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSisi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
