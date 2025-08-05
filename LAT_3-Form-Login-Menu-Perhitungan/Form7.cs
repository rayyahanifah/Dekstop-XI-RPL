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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            double panjang, lebar, tinggi;

            if (double.TryParse(txtPanjang.Text, out panjang) &&
                double.TryParse(txtLebar.Text, out lebar) &&
                double.TryParse(txtTinggi.Text, out tinggi))
            {
                double luasAlas = panjang * lebar;
                double kelilingAlas = 2 * (panjang + lebar);

                double volume = (1.0 / 3.0) * luasAlas * tinggi;

                txtLuas.Text = luasAlas.ToString("F2");
                txtKeliling.Text = kelilingAlas.ToString("F2");
                txtVolume.Text = volume.ToString("F2");
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid untuk panjang, lebar, dan tinggi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtVolume.Clear();
            txtTinggi.Clear();
            txtPanjang.Clear();
            txtLuas.Clear();
            txtLebar.Clear();
            txtKeliling.Clear();
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
    }
}
