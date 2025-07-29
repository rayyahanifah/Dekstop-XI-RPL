namespace LAT2_Input_Data
{
    public partial class Form1 : Form
    {
        string ktp;
        string nama;
        string tempat;
        string agama;
        string email;
        string alamat;

        public Form1()
        {
            InitializeComponent();
            cmbKelamin.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringjeniskelamin = cmbKelamin.SelectedItem.ToString();
            DateTime stringtanggallahir = dateTanggal.Value;
            ktp = txtKtp.Text;
            nama = txtNama.Text;
            tempat = txtTempat.Text;
            agama = txtAgama.Text;
            email = txtEmail.Text;
            alamat = txtAlamat.Text;

            Form2 form2 = new Form2(
                ktp,
                nama,
                tempat,
                agama,
                email,
                alamat,
                stringjeniskelamin,
                stringtanggallahir
                );


            form2.Show();
            this.Hide();
        }

        private void tblHapus_Click(object sender, EventArgs e)
        {
            txtKtp.Clear();
            txtNama.Clear();
            txtAgama.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();
            txtTempat.Clear();
        }

        private void tblTutup1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
