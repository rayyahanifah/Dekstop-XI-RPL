using System.Globalization;

namespace TUGAS_Kalkulator_Menu_Warteg
{
    public partial class Form1 : Form
    {
        double hargaKarbo = 0;
        double hargaMinum = 0;
        double hargaProtein = 0;
        double hargaTambahan = 0;
        double pajak = 0.2;

        double totalKarbohidrat = 0;
        double totalEnergi = 0;
        double totalProtein = 0;
        double totalLemak = 0;

        CultureInfo indo = new CultureInfo("id-ID");

        public static double subtotal;
        public static double nilaiPajak;
        public static double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void HitungTotal()
        {
            subtotal = hargaKarbo + hargaMinum + hargaProtein + hargaTambahan;
            nilaiPajak = subtotal * pajak;
            total = subtotal + nilaiPajak;

            txtHarga.Text = subtotal.ToString("C0", indo);
            txtPajak.Text = nilaiPajak.ToString("C0", indo);
            txtTotal.Text = total.ToString("C0", indo);
        }

        //disini
        private void HitungKandungan()
        {
            txtKarbohidrat.Text = totalKarbohidrat.ToString() + " gram";
            txtEnergi.Text = totalEnergi.ToString() + " kkal";
            txtProtein.Text = totalProtein.ToString() + " gram";
            txtLemak.Text = totalLemak.ToString() + " gram";
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            txtHarga.Clear();
            txtPajak.Clear();
            txtTotal.Clear();
            txtKarbohidrat.Clear();
            txtLemak.Clear();
            txtProtein.Clear();
            txtEnergi.Clear();
            txtNama.Clear();

            rbtnAirPutih.Checked = false;
            rbtnBuburAyam.Checked = false;
            rbtnBuburKacangHijau.Checked = false;
            rbtnBuburKetanHitam.Checked = false;
            rbtnJusAlpukat.Checked = false;
            rbtnJusJeruk.Checked = false;
            rbtnJusMangga.Checked = false;
            rbtnJusPepaya.Checked = false;
            rbtnNasi1.Checked = false;
            rbtnNasi2.Checked = false;
            rbtnTehManis.Checked = false;
            rbtnTehTawar.Checked = false;   
            cbAyam.Checked = false;
            cbBakwan.Checked = false;
            cbCapcay.Checked = false;   
            cbKerupuk.Checked = false;  
            cbKikil.Checked = false;
            cbLumpiaTahu.Checked = false;
            cbPisang.Checked = false;   
            cbSayurLabu.Checked = false;
            cbTahuIsi.Checked = false;
            cbTempe.Checked = false;
            cbTempeGoreng.Checked = false;
            cbTumisToge.Checked = false;
            cbUsus.Checked = false;
            checkBox4.Checked = false;
        }

        //Karbohidrat
        private void rbtnNasi1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNasi1.Checked)
            {
                hargaKarbo += 5000;
                totalEnergi += 210;
                totalKarbohidrat += 45;
                totalProtein += 4;
                totalLemak += 0.5;
            }
            else
            {
                hargaKarbo -= 5000;
                totalEnergi -= 210;
                totalKarbohidrat -= 45;
                totalProtein -= 4;
                totalLemak -= 0.5;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnNasi2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNasi2.Checked)
            {
                hargaKarbo += 3000;
                totalEnergi += 105;
                totalKarbohidrat += 22.5;
                totalProtein += 2;
                totalLemak += 0.2;
            }
            else
            {
                hargaKarbo -= 3000;
                totalEnergi -= 105;
                totalKarbohidrat -= 22.5;
                totalProtein -= 2;
                totalLemak -= 0.2;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnBuburAyam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBuburAyam.Checked)
            {
                hargaKarbo += 12000;
                totalEnergi += 250;
                totalKarbohidrat += 30;
                totalProtein += 10;
                totalLemak += 10;
            }
            else
            {
                hargaKarbo -= 12000;
                totalEnergi -= 250;
                totalKarbohidrat -= 30;
                totalProtein -= 10;
                totalLemak -= 10;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnBuburKacangHijau_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBuburKacangHijau.Checked)
            {
                hargaKarbo += 10000;
                totalEnergi += 180;
                totalKarbohidrat += 32;
                totalProtein += 9;
                totalLemak += 2;
            }
            else
            {
                hargaKarbo -= 10000;
                totalEnergi -= 180;
                totalKarbohidrat -= 32;
                totalProtein -= 9;
                totalLemak -= 2;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnBuburKetanHitam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBuburKetanHitam.Checked)
            {
                hargaKarbo += 10000;
                totalEnergi += 220;
                totalKarbohidrat += 40;
                totalProtein += 5;
                totalLemak += 3;
            }
            else
            {
                hargaKarbo -= 10000;
                totalEnergi -= 220;
                totalKarbohidrat -= 40;
                totalProtein -= 5;
                totalLemak -= 3;
            }
            HitungTotal();
            HitungKandungan();
        }

        //Minuman
        private void rbtnTehTawar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTehTawar.Checked)
            {
                hargaMinum += 3000;
                totalEnergi += 1;
                totalKarbohidrat += 0;
                totalProtein += 0;
                totalLemak += 0;
            }
            else
            {
                hargaMinum -= 3000;
                totalEnergi -= 1;
                totalKarbohidrat -= 0;
                totalProtein -= 0;
                totalLemak -= 0;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnTehManis_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTehManis.Checked)
            {
                hargaMinum += 5000;
                totalEnergi += 90;
                totalKarbohidrat += 22;
                totalProtein += 0;
                totalLemak += 0;
            }
            else
            {
                hargaMinum -= 5000;
                totalEnergi -= 90;
                totalKarbohidrat -= 22;
                totalProtein -= 0;
                totalLemak -= 0;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnJusJeruk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJusJeruk.Checked)
            {
                hargaMinum += 5000;
                totalEnergi += 110;
                totalKarbohidrat += 25;
                totalProtein += 0;
                totalLemak += 0;
            }
            else
            {
                hargaMinum -= 5000;
                totalEnergi -= 110;
                totalKarbohidrat -= 25;
                totalProtein -= 0;
                totalLemak -= 0;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnJusAlpukat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJusAlpukat.Checked)
            {
                hargaMinum += 8000;
                totalEnergi += 180;
                totalKarbohidrat += 12;
                totalProtein += 3;
                totalLemak += 15;
            }
            else
            {
                hargaMinum -= 8000;
                totalEnergi -= 180;
                totalKarbohidrat -= 12;
                totalProtein -= 3;
                totalLemak -= 15;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnJusMangga_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJusMangga.Checked)
            {
                hargaMinum += 9000;
                totalEnergi += 130;
                totalKarbohidrat += 30;
                totalProtein += 1;
                totalLemak += 0.5;
            }
            else
            {
                hargaMinum -= 9000;
                totalEnergi -= 130;
                totalKarbohidrat -= 30;
                totalProtein -= 1;
                totalLemak -= 0.5;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtnJusPepaya_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJusPepaya.Checked)
            {
                hargaMinum += 7000;
                totalEnergi += 120;
                totalKarbohidrat += 28;
                totalProtein += 1;
                totalLemak += 0.5;
            }
            else
            {
                hargaMinum -= 7000;
                totalEnergi -= 120;
                totalKarbohidrat -= 28;
                totalProtein -= 1;
                totalLemak -= 0.5;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void rbtAirPutih_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAirPutih.Checked)
            {
                hargaMinum += 0;
                totalEnergi += 0;
                totalKarbohidrat += 0;
                totalProtein += 0;
                totalLemak += 0;
            }
            else
            {
                hargaMinum -= 0;
                totalEnergi -= 0;
                totalKarbohidrat -= 0;
                totalProtein -= 0;
                totalLemak -= 0;
            }
            HitungTotal();
            HitungKandungan();

        }

        //Protein
        private void cbAyam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAyam.Checked)
            {
                hargaProtein += 7000;
                totalEnergi += 260;
                totalKarbohidrat += 0;
                totalProtein += 20;
                totalLemak += 20;
            }
            else
            {
                hargaProtein -= 7000;
                totalEnergi -= 260;
                totalKarbohidrat -= 0;
                totalProtein -= 20;
                totalLemak -= 20;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                hargaProtein += 5000;
                totalEnergi += 155;
                totalKarbohidrat += 2;
                totalProtein += 7;
                totalLemak += 12;
            }
            else
            {
                hargaProtein -= 5000;
                totalEnergi -= 155;
                totalKarbohidrat -= 2;
                totalProtein -= 7;
                totalLemak -= 12;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbKikil_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKikil.Checked)
            {
                hargaProtein += 4000;
                totalEnergi += 80;
                totalKarbohidrat += 0;
                totalProtein += 12;
                totalLemak += 5;
            }
            else
            {
                hargaProtein -= 4000;
                totalEnergi -= 80;
                totalKarbohidrat -= 0;
                totalProtein -= 12;
                totalLemak -= 5;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbUsus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUsus.Checked)
            {
                hargaProtein += 4000;
                totalEnergi += 120;
                totalKarbohidrat += 0;
                totalProtein += 15;
                totalLemak += 7;
            }
            else
            {
                hargaProtein -= 4000;
                totalEnergi -= 120;
                totalKarbohidrat -= 0;
                totalProtein -= 15;
                totalLemak -= 7;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbTempe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTempe.Checked)
            {
                hargaProtein += 4000;
                totalEnergi += 150;
                totalKarbohidrat += 8;
                totalProtein += 10;
                totalLemak += 8;
            }
            else
            {
                hargaProtein -= 4000;
                totalEnergi -= 150;
                totalKarbohidrat -= 8;
                totalProtein -= 10;
                totalLemak -= 8;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbCapcay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCapcay.Checked)
            {
                hargaProtein += 4000;
                totalEnergi += 90;
                totalKarbohidrat += 10;
                totalProtein += 4;
                totalLemak += 4;
            }
            else
            {
                hargaProtein -= 4000;
                totalEnergi -= 90;
                totalKarbohidrat -= 10;
                totalProtein -= 4;
                totalLemak -= 4;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbSayurLabu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSayurLabu.Checked)
            {
                hargaProtein += 3000;
                totalEnergi += 60;
                totalKarbohidrat += 8;
                totalProtein += 1.5;
                totalLemak += 2;
            }
            else
            {
                hargaProtein -= 3000;
                totalEnergi -= 60;
                totalKarbohidrat -= 8;
                totalProtein -= 1.5;
                totalLemak -= 2;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbTumisToge_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTumisToge.Checked)
            {
                hargaProtein += 3000;
                totalEnergi += 50;
                totalKarbohidrat += 4;
                totalProtein += 2;
                totalLemak += 2;
            }
            else
            {
                hargaProtein -= 3000;
                totalEnergi -= 50;
                totalKarbohidrat -= 4;
                totalProtein -= 2;
                totalLemak -= 2;
            }
            HitungTotal();
            HitungKandungan();
        }

        //Tambahan
        private void cbTahuIsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTahuIsi.Checked)
            {
                hargaTambahan += 2000;
                totalEnergi += 100;
                totalKarbohidrat += 8;
                totalProtein += 4;
                totalLemak += 6;
            }
            else
            {
                hargaTambahan -= 2000;
                totalEnergi -= 100;
                totalKarbohidrat -= 8;
                totalProtein -= 14;
                totalLemak -= 6;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbBakwan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBakwan.Checked)
            {
                hargaTambahan += 1000;
                totalEnergi += 80;
                totalKarbohidrat += 10;
                totalProtein += 2;
                totalLemak += 4;
            }
            else
            {
                hargaTambahan -= 1000;
                totalEnergi -= 80;
                totalKarbohidrat -= 10;
                totalProtein -= 2;
                totalLemak -= 4;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbTempeGoreng_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTempeGoreng.Checked)
            {
                hargaTambahan += 1000;
                totalEnergi += 85;
                totalKarbohidrat += 6;
                totalProtein += 3;
                totalLemak += 5;
            }
            else
            {
                hargaTambahan -= 1000;
                totalEnergi -= 85;
                totalKarbohidrat -= 6;
                totalProtein -= 3;
                totalLemak -= 5;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbLumpiaTahu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLumpiaTahu.Checked)
            {
                hargaTambahan += 2000;
                totalEnergi += 110;
                totalKarbohidrat += 12;
                totalProtein += 4;
                totalLemak += 6;
            }
            else
            {
                hargaTambahan -= 2000;
                totalEnergi -= 110;
                totalKarbohidrat -= 12;
                totalProtein -= 4;
                totalLemak -= 6;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbPisang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPisang.Checked)
            {
                hargaTambahan += 2000;
                totalEnergi += 120;
                totalKarbohidrat += 20;
                totalProtein += 1;
                totalLemak += 4;
            }
            else
            {
                hargaTambahan -= 2000;
                totalEnergi -= 120;
                totalKarbohidrat -= 20;
                totalProtein -= 1;
                totalLemak -= 4;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void cbKerupuk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTahuIsi.Checked)
            {
                hargaTambahan += 1000;
                totalEnergi += 45;
                totalKarbohidrat += 5;
                totalProtein += 0.5;
                totalLemak += 3;
            }
            else
            {
                hargaTambahan -= 1000;
                totalEnergi -= 45;
                totalKarbohidrat -= 5;
                totalProtein -= 0.5;
                totalLemak -= 3;
            }
            HitungTotal();
            HitungKandungan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Masukkan Nama Anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            string nama = txtNama.Text;

            List<string> pesanan = new List<string>();

            // Karbohidrat
            if (rbtnNasi1.Checked)
            {
                pesanan.Add("Nasi 1 Porsi - 5000");
            }
            if (rbtnNasi2.Checked)
            {
                pesanan.Add("Ayam ½ Porsi - 3000");
            }
            if (rbtnBuburAyam.Checked)
            {
                pesanan.Add("Bubur Ayam - 10000");
            }
            if (rbtnBuburKacangHijau.Checked)
            {
                pesanan.Add("Bubur Kacang Hijau - 10000");
            }
            if (rbtnBuburKetanHitam.Checked)
            {
                pesanan.Add("Bubur Ketan Hitam - 10000");
            }

            // Lauk
            if (cbAyam.Checked)
            {
                pesanan.Add("Ayam Goreng - 7000");
            }
            if (checkBox4.Checked)
            {
                pesanan.Add("Telur Balado - 5000");
            }
            if (cbKikil.Checked)
            {
                pesanan.Add("Kikil - 4000");
            }
            if (cbUsus.Checked)
            {
                pesanan.Add("Usus - 4000");
            }
            if (cbTempe.Checked)
            {
                pesanan.Add("Tempe Orek - 4000");
            }
            if (cbCapcay.Checked)
            {
                pesanan.Add("Capcay - 4000");
            }
            if (cbSayurLabu.Checked)
            {
                pesanan.Add("Sayur Labu - 3000");
            }

            // Minuman
            if (rbtnTehTawar.Checked)
            {
                pesanan.Add("Teh Tawar - 3000");
            }
            if (rbtnTehManis.Checked)
            {
                pesanan.Add("Teh Manis - 5000");
            }
            if (rbtnJusAlpukat.Checked)
            {
                pesanan.Add("Jus Alpukat - 8000");
            }
            if (rbtnJusJeruk.Checked)
            {
                pesanan.Add("Jus Jeruk - 5000");
            }
            if (rbtnJusMangga.Checked)
            {
                pesanan.Add("Jus Mangga - 9000");
            }
            if (rbtnJusPepaya.Checked)
            {
                pesanan.Add("Jus Pepaya - 7000");
            }
            if (rbtnAirPutih.Checked)
            {
                pesanan.Add("Air Mineral - 0");
            }

            // Tambahan
            if (cbKerupuk.Checked)
            {
                pesanan.Add("Kerupuk - 1000");
            }
            if (cbTempeGoreng.Checked)
            {
                pesanan.Add("Tempe Goreng - 1000");
            }
            if (cbTahuIsi.Checked)
            {
                pesanan.Add("Tahu Isi - 2000");
            }
            if (cbPisang.Checked)
            {
                pesanan.Add("Pisang Goreng - 2000");
            }
            if (cbLumpiaTahu.Checked)
            {
                pesanan.Add("Lumpia Tahu - 2000");
            }
            if (cbBakwan.Checked)
            {
                pesanan.Add("Bakwan - 1000");
            }

            Form2 form = new Form2(nama, pesanan);
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
