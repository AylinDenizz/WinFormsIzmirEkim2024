using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        List<Skor> skorlar = new List<Skor>();

        List<int> deste = new List<int>(); // kart numarasını tutacak (0-51)
        enum KartTuru { Kupa = 0, Karo = 1, Sinek = 2, Maca = 3 };    // her türde 13 kart var
        int siradakiOyuncu;
        int oyuncuSayi1;
        int oyuncuSayi2;
        int pas1 = 0;
        int pas2 = 0;



        public Form1()
        {
            InitializeComponent();
            lblKazanan.Visible = false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            deste.Clear();
            for (int i = 0; i < 52; i++)//tüm kartlarý desteye ekle
            {
                deste.Add(i);
                lblKazanan.Visible = false;
            }


            Random rnd = new Random();

            for (int k = 0; k < 3; k++)
                for (int i = 0; i < deste.Count; i++)
                {
                    int rasgele = rnd.Next(0, deste.Count);//indeks
                    int kart = deste[rasgele];
                    deste.RemoveAt(rasgele);//kartý desteden çýkar
                    deste.Add((int)kart);//kartý destenin sonuna ekle
                }

            lblDesteKartSayisi.Text = deste.Count.ToString();

            pbDeste.Image = Properties.Resources.KartArka;

            pnlOyuncu1.Controls.Clear();
            pnlOyuncu2.Controls.Clear();

            oyuncuSayi1 = 0;
            oyuncuSayi2 = 0;
            pas1 = 0;
            pas2 = 0;

            lblOyuncu1Sayi.Text = oyuncuSayi1.ToString();
            lblOyuncu2Sayi.Text = oyuncuSayi2.ToString();

            lblKazanan.Visible = false;

            siradakiOyuncuyuDegistir(0);
        }





        private void btnKartCek1_Click(object sender, EventArgs e)
        {

            int sayi = kartCek(pnlOyuncu1);
            oyuncuSayi1 += sayi;
            lblOyuncu1Sayi.Text = oyuncuSayi1.ToString();
            lblOyuncu2Sayi.Text = oyuncuSayi2.ToString();
            if (!OyunBittiMiKontrolEt())
                siradakiOyuncuyuDegistir(1);
        }

        private void btnKartCek2_Click(object sender, EventArgs e)
        {
            int sayi = kartCek(pnlOyuncu2);
            oyuncuSayi2 += sayi;
            lblOyuncu1Sayi.Text = oyuncuSayi1.ToString();
            lblOyuncu2Sayi.Text = oyuncuSayi2.ToString();
            if (!OyunBittiMiKontrolEt())
                siradakiOyuncuyuDegistir(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbDeste_Click(object sender, EventArgs e)
        {

        }


        void siradakiOyuncuyuDegistir(int sira)
        {
            siradakiOyuncu = sira;
            if (siradakiOyuncu == 0)
            {
                lblOyuncu1.BackColor = Color.Red;
                lblOyuncu1.ForeColor = Color.White;
                pnlOyuncu1Butonlar.Enabled = true;
                lblOyuncu2.BackColor = Color.Green;
                lblOyuncu2.ForeColor = Color.Black;
                pnlOyuncu2Butonlar.Enabled = false;
            }
            else if (siradakiOyuncu == 1)
            {
                lblOyuncu1.BackColor = Color.Green;
                lblOyuncu1.ForeColor = Color.Black;
                lblOyuncu2.BackColor = Color.Red;
                lblOyuncu2.ForeColor = Color.White;
                pnlOyuncu2Butonlar.Enabled = true;
                pnlOyuncu1Butonlar.Enabled = false;

            }
        }

        int kartCek(Panel pnl)
        {
            int kart = deste[0];

            deste.RemoveAt(0);//0.indeksten sil
            lblDesteKartSayisi.Text = deste.Count.ToString();

            int sira = kart % 13;
            int grup = kart / 13;

            KartTuru tur = (KartTuru)grup;
            string resAdi = $"{tur}{sira + 1}";


            //caliþma zamaný kontrol oluþtur
            PictureBox pb = new PictureBox();
            pb.Size = new Size(103, 140);

            pb.Location = new Point(5 + pnl.Controls.Count * 25, 5);

            pb.Image = (Image)Properties.Resources.ResourceManager.GetObject(resAdi);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            pnl.Controls.Add(pb);

            pb.BringToFront();

            return sira + 1;

        }

        private void btnPas1_Click(object sender, EventArgs e)
        {
            pas1++;

            if (!OyunBittiMiKontrolEt())
                siradakiOyuncuyuDegistir(1);
        }

        private void btnPas2_Click(object sender, EventArgs e)
        {
            pas2++;

            if (!OyunBittiMiKontrolEt())
                siradakiOyuncuyuDegistir(0);
        }

        bool OyunBittiMiKontrolEt()
        {
            bool durum = false;
            int kazanan = 0;

            if (oyuncuSayi1 > 21) { kazanan = 1; durum = true; }
            else if (oyuncuSayi2 > 21) { kazanan = 0; durum = true; }


            else if (oyuncuSayi1 == 21) { kazanan = 0; durum = true; }
            else if (oyuncuSayi2 == 21) { kazanan = 1; durum = true; }

            else if (pas1 == 2 && pas2 == 2)
            {
                if (oyuncuSayi1 > oyuncuSayi2)
                    kazanan = 0;
                else if (oyuncuSayi1 < oyuncuSayi2)
                    kazanan = 1;
                else
                    kazanan = 2;//Beraberlik

                durum = true;

            }

            if (durum)
                OyunBitti(kazanan);

            return durum;
        }


        void OyunBitti(int kazanan)
        {
            lblOyuncu1.BackColor = Color.FromArgb(192, 255, 192);
            lblOyuncu1.ForeColor = Color.Black;
            pnlOyuncu1Butonlar.Enabled = false;

            lblOyuncu2.BackColor = Color.FromArgb(192, 255, 192);
            lblOyuncu2.ForeColor = Color.Black;
            pnlOyuncu2Butonlar.Enabled = false;

            lblKazanan.Text = "KAZANAN";

            if (kazanan == 0)
            {

                lblKazanan.Location = new Point(lblOyuncu1.Left + (lblOyuncu1.Width - lblKazanan.Width) / 2, lblOyuncu1.Top - lblKazanan.Height - 10);
            }
            else if (kazanan == 1)
            {
                lblKazanan.Location = new Point(lblOyuncu2.Left + (lblOyuncu2.Width - lblKazanan.Width) / 2, lblOyuncu2.Top - lblKazanan.Height - 10);

            }
            else
            {
                lblKazanan.Text = "BERABERE";
                lblKazanan.Location = new Point((Width - lblKazanan.Width) / 2, lblOyuncu2.Top - lblKazanan.Height - 10);

            }

            pbDeste.Image = null;
            lblDesteKartSayisi.Text = "0";
            deste.Clear();

            lblKazanan.Visible = true;

            Skor s = new Skor() { Oyuncu1Puan = oyuncuSayi1, Oyuncu2Puan = oyuncuSayi2 };
            skorlar.Add(s);

        }

        private void btnSkorlar_Click(object sender, EventArgs e)
        {
            SkorForm form = new SkorForm(skorlar);
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel4.Location = new Point((Width - panel1.Width) / 2, (Height - panel1.Height) / 2);
        }

        private void pnlOyuncu2_SizeChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


