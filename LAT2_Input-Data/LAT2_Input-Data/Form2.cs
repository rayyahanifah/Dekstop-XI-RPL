using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LAT2_Input_Data
{
    public partial class Form2 : Form
    {
        public Form2(
            string ktp, string nama, string tempat, string agama, string email, string alamat, string cmbKelamin, DateTime dateTanggal)
        {
            InitializeComponent();
            lblKtp.Text = ktp;
            lblNama.Text = nama;
            lblTempat.Text = tempat;
            lblAgama.Text = agama;
            lblEmail.Text = email;
            lblAlamat.Text = alamat;
            lblKelamin.Text = cmbKelamin;
            lblTanggal.Text = dateTanggal.ToString("dd MMM yyyy");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tblTutup2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblKembali_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
