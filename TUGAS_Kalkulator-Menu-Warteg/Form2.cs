using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGAS_Kalkulator_Menu_Warteg
{
    public partial class Form2 : Form
    {
        CultureInfo indo = new CultureInfo("id-ID");

        public Form2(string nama, List<string> pesanan)
        {
            InitializeComponent();

            // Tampilkan nama pembeli
            lblNama.Text = nama;

            // Tampilkan daftar pesanan
            foreach (string item in pesanan)
            {
                listBoxPesanan.Items.Add(item);
            }

            // Tampilkan total harga
            txtTotal.Text = Form1.total.ToString("C0", indo);
            txtPajak.Text = Form1.nilaiPajak.ToString("C0", indo);
            txtHarga.Text = Form1.subtotal.ToString("C0", indo);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tblKembali_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
