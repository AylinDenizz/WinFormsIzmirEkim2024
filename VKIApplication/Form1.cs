namespace IlkUygulama
{
    public partial class asdf : Form
    {
        public asdf()//yapýcý metot
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            //text box'a kullanýcýnýn girdiði deðeri oku
            string adSoyad = txtAdSoyad.Text;
            //ekrana mesaj diyalog penceresi getirir
            MessageBox.Show($"Merhaba, {adSoyad}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
