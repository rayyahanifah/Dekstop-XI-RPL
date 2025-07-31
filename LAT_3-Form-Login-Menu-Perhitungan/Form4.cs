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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            double r;

            if (double.TryParse(txtJariJari.Text, out r))
            {
                double phi = 3.14;

                double luas = 4 * phi * r * r;               // Luas permukaan bola
                double keliling = 2 * phi * r;               // Keliling lingkaran besar
                double volume = (4.0 / 3.0) * phi * r * r * r; // Volume bola

                txtLuas.Text = luas.ToString("F2");
                txtKeliling.Text = keliling.ToString("F2");
                txtVolume.Text = volume.ToString("F2");
            }
            else
            {
                MessageBox.Show("Masukkan angka valid untuk jari-jari!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtJariJari.Clear();
            txtKeliling.Clear();
            txtLuas.Clear();
            txtVolume.Clear();
        }

        private void tblTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
