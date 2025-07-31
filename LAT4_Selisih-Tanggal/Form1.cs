using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace LAT4_Selisih_Tanggal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tblHasil_Click(object sender, EventArgs e)
        {
            DateTime tanggal1 = date1.Value.Date;
            DateTime tanggal2 = date2.Value.Date;

            TimeSpan selisih = tanggal2 - tanggal1;
            int jumlahHari = Math.Abs(selisih.Days);

            txtSelisih.Text = jumlahHari.ToString() + " hari";

            if (selisih.Days > 0)
            {
                rtbKeterangan.Text = "Tanggal Kedua lebih baru dari Tanggal Pertama.";
            }
            else if (selisih.Days < 0)
            {
                rtbKeterangan.Text = "Tanggal Pertama lebih baru dari Tanggal Kedua.";
            }
            else
            {
                rtbKeterangan.Text = "Tanggal Pertama dan Tanggal Kedua adalah sama.";
            }
        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtSelisih.Clear();
            rtbKeterangan.Clear();
        }
    }
}
