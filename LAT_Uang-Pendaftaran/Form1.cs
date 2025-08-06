namespace LAT_Uang_Pendaftaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblTugas12_Click(object sender, EventArgs e)
        {
            FormTugas12 form = new FormTugas12();
            form.Show();
            this.Hide();
        }

        private void tblTugas13_Click(object sender, EventArgs e)
        {
            FormTugas13 form = new FormTugas13();
            form.Show();
            this.Hide();
        }

        private void tblTugas14_Click(object sender, EventArgs e)
        {
            FormTugas14 form = new FormTugas14();
            form.Show();
            this.Hide();
        }
    }
}
