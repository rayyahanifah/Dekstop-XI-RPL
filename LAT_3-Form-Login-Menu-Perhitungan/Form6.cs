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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            double jari, tinggi;

            if (double.TryParse(txtJariJari.Text, out jari) &&
                double.TryParse(txtTinggi.Text, out tinggi))
            {
                double phi = 3.14;

                double luas = 2 * phi * jari * (jari + tinggi);
                double keliling = 2 * phi * jari;
                double volume = phi * jari * jari * tinggi;

                txtLuas.Text = luas.ToString("F2");
                txtKeliling.Text = keliling.ToString("F2");
                txtVolume.Text = volume.ToString("F2");
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid untuk jari-jari dan tinggi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtJariJari.Clear();
            txtKeliling.Clear();
            txtLuas.Clear();
            txtTinggi.Clear();
            txtVolume.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void tblTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
