using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace LAT1_Hitung_Nilai_Rata_Rata
{

    public partial class Form1 : Form
    {
        Double dblNilaiHarian = 0;
        Double dblNilaiTengah = 0;
        Double dblNilaiAkhir = 0;
        Double dblNama = 0;
        Double dblNilaiRata = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            // Inisialisasi
            dblNilaiHarian = Double.Parse(txtNilaiHarian.Text);
            dblNilaiTengah = Double.Parse(txtNilaiTengah.Text);
            dblNilaiAkhir = Double.Parse(txtNilaiAkhir.Text);

            double bobotNilaiHarian = 0.5;
            double bobotNilaiTengah = 0.3;
            double bobotNilaiAkhir = 0.2;

            double kkm = 78.0;

            dblNilaiRata = (dblNilaiHarian * bobotNilaiHarian) +
                          (dblNilaiTengah * bobotNilaiTengah) +
                          (dblNilaiAkhir * bobotNilaiAkhir);


            txtNilaiRata.Text = dblNilaiRata.ToString("N2");

            string keterangan = dblNilaiRata >= kkm ? "KOMPETEN" : "TIDAK KOMPETEN";
            txtKeterangan.Text = keterangan;

            string kategori;

            if (dblNilaiRata >= 90)
            {
                kategori = "A";
            }
            else if (dblNilaiRata >= 80)
            {
                kategori = "B";
            }
            else if (dblNilaiRata >= 70)
            {
                kategori = "C";
            }
            else if (dblNilaiRata < 70)
            {
                kategori = "D";
            }
            else
            {
                kategori = "NGACO";
            }

            txtKategori.Text = kategori;

        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtNilaiHarian.Clear();
            txtNilaiTengah.Clear();
            txtNilaiAkhir.Clear();
            txtNilaiRata.Clear();
            txtKeterangan.Clear();
            txtKategori.Clear();
        }

        private void tblTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSimpan_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
