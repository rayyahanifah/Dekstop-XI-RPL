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

namespace LAT3_Kalkulator_Combobox
{
    public partial class Form1 : Form
    {

        Double dblInput1 = 0.0;
        Double dblInput2 = 0.0;
        Double dblHasil = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tblHasil_Click(object sender, EventArgs e)
        {
            dblInput1 = Double.Parse(txtInput1.Text);
            dblInput2 = Double.Parse(txtInput2.Text);

            if ((txtInput1.Text == "") || (txtInput2.Text == ""))
                MessageBox.Show("Isi Semua Kocak!!!");
            else
            {
                if (cmbOperasi.SelectedIndex == -1)
                    MessageBox.Show("Pilih Operasi Dulu Kocak!!");

                else if (cmbOperasi.SelectedIndex == 0)
                {
                    dblHasil = dblInput1 + dblInput2;
                    txtHasil.Text = dblHasil.ToString();
                }

                else if (cmbOperasi.SelectedIndex == 1)
                {
                    dblHasil = dblInput1 - dblInput2;
                    txtHasil.Text = dblHasil.ToString();
                }

                else if (cmbOperasi.SelectedIndex == 2)
                {
                    dblHasil = dblInput1 * dblInput2;
                    txtHasil.Text = dblHasil.ToString();
                }

                else if (cmbOperasi.SelectedIndex == 3)
                {
                    dblHasil = dblInput1 / dblInput2;
                    txtHasil.Text = dblHasil.ToString();
                }

            }

            string operasi = cmbOperasi.SelectedItem.ToString();
            string hasil = $"{txtInput1.Text} {operasi} {txtInput2.Text} = {txtHasil.Text}";
            History.Items.Add(hasil);

        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtHasil.Clear();
            txtInput1.Clear();
            txtInput2.Clear();
            cmbOperasi.SelectedIndex = -1;
        }

        private void History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tblHapusHistory_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }
    }
}
