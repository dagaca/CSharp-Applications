namespace ThreadingDemo_1
{
    //multithread yap� da birden fazla thread vard�r fakat bir thread iki i�lem i�in kullan�lamaz.
    //asenkron programlamada da multithread yap� mevcuttur art� bir avantaj olarakta bir thread iki i�lem i�in kullan�labilir.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 1 �al��t�");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 2 �al��t�");
        }
    }
}
