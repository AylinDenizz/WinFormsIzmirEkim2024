using System;

namespace PersonelBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DosyaYardimcisi.VerileriYukle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DosyaYardimcisi.VerileriYukle();

            lboxPersoneller.VeriBagla(DosyaYardimcisi.PersonelleriGetir(),
                   "Id", "Adsoyad");
        }


            private ListBox GetLboxPersoneller()
        {
            return lboxPersoneller;
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            Personel yeni = lboxPersoneller.SelectedItem as Personel;
            if (yeni == null)
                yeni = new Personel();

            yeni.Id = 0;
            yeni.AdSoyad = txtAdSoyad.Text;
            yeni.CalistigiBirim = txtCalistigiBirim.Text;
            yeni.Cinsiyet = cBoxCinsiyet.SelectedIndex;//seçili olan elamnýn sýrasý
            yeni.CalisanTipi = cBoxCalisanTipi.SelectedIndex;

            //****************************************************************************
            CheckBox[] chk = { null, chkPzt, chkSal, chkCrs, chkPrs, chkCum, chkCmt, chkPaz };
            int gunler = 0;
            Array degerler = Enum.GetValues(typeof(Gunler));

            for (int i = 1; i < chk.Length; i++)
            {
                CheckBox c = chk[i];

                if (c.Checked) gunler |= (int)degerler.GetValue(i);
            }
            //*****************************************************************************

            yeni.CalismaGunleri = gunler;

            if (rdSureliSozlesmeli.Checked)
                yeni.PersonelDurumu = (int)PersonelDurumu.SureliSözlesmeli;
            else if (rdKadrolu.Checked)
                yeni.PersonelDurumu = (int)PersonelDurumu.kadrolu;
            else if (rdPartTime.Checked)
                yeni.PersonelDurumu = (int)PersonelDurumu.PartTime;
            else
                yeni.PersonelDurumu = (int)PersonelDurumu.Stajyer;


            if (lboxPersoneller.SelectedItem == null)//eski persomnel seçili deðilse ekle
                DosyaYardimcisi.PersonelEkle(yeni);
          
            lboxPersoneller.VeriBagla(DosyaYardimcisi.PersonelleriGetir(),
                         "Id", "Adsoyad");
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            DosyaYardimcisi.VerileriKaydet();
            MessageBox.Show("Veriler kayıt edildi.");
        }

        private void lboxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçili eleman yoksa pers = (Personle) null ve bu hata oluþturur
            Personel pers = lboxPersoneller.SelectedItem as Personel;
            //as operatörü deðer null deðilse convert eder, null ise null döner 

            if (pers != null)//var ise
            {
                txtAdSoyad.Text = pers.AdSoyad;
                txtCalistigiBirim.Text = pers.CalistigiBirim;
                cBoxCinsiyet.SelectedIndex = pers.Cinsiyet;
                cBoxCalisanTipi.SelectedIndex = pers.CalisanTipi;

                //to do:çalýþma günlerini göster

                if (pers.PersonelDurumu == (int)PersonelDurumu.SureliSözlesmeli)
                    rdSureliSozlesmeli.Checked = true;
                else if (pers.PersonelDurumu == (int)PersonelDurumu.kadrolu)
                    rdKadrolu.Checked = true;
                else if (pers.PersonelDurumu == (int)PersonelDurumu.Stajyer)
                    rdStajyer.Checked = true;
                else if (pers.PersonelDurumu == (int)PersonelDurumu.PartTime)
                    rdPartTime.Checked = true;

            }
            else//yok ise
            {
                txtAdSoyad.Text = "";
                txtCalistigiBirim.Text = "";
                cBoxCinsiyet.SelectedIndex = -1;
                cBoxCalisanTipi.SelectedIndex = -1;
                rdPartTime.Checked = rdStajyer.Checked = rdKadrolu.Checked = rdSureliSozlesmeli.Checked = false;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lboxPersoneller.SelectedIndex = -1;
        }

        private void txtCalistigiBirim_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbSil_Click(object sender, EventArgs e)
        {
            Personel pers = lboxPersoneller.SelectedItem as Personel;

            if (pers != null)
            {
                var cevap = MessageBox.Show($"{pers.AdSoyad} adlý personeli silmek istediðinize" +
                    $" emin misiniz?", "Uyarý", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    DosyaYardimcisi.PersonelSil(pers);

                    lboxPersoneller.VeriBagla(DosyaYardimcisi.PersonelleriGetir(),
                        "Id", "Adsoyad");
                }
            }
        }


    }
}

