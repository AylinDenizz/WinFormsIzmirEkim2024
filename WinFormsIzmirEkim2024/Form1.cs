namespace VKIuygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(txtBoy.Text);
            double kilo = Convert.ToDouble(txtKilo.Text);

            double boyMetre = boy / 100;

            double vki = kilo / (boyMetre * boyMetre);

            lblSonuc.Text = $"VKİ DEĞER = {vki:f2}";

            if (vki < 18.5)
            {
                lblDurum.Text = "ZAYIF";
            }
            else if (vki < 25)
            {
                lblDurum.Text = "NORMAL";
            }
            else if (vki < 30)
            {
                lblDurum.Text = "KİLOLU";
            }
            else
            {
                lblDurum.Text = "OBEZ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
