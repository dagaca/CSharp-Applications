namespace ThreadingDemo_1
{
    //multithread yapý da birden fazla thread vardýr fakat bir thread iki iþlem için kullanýlamaz.
    //asenkron programlamada da multithread yapý mevcuttur artý bir avantaj olarakta bir thread iki iþlem için kullanýlabilir.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 çalýþtý");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 çalýþtý");
        }
    }
}
