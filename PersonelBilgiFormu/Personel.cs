using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiFormu
{
    public class Personel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string CalistigiBirim { get; set; }
        public int Cinsiyet { get; set; } //0-Erkek 1-Kadın
        public int Turu { get; set; }
        public int CalismaGunleri { get; set; } //Flag
        public int PersonelDurumu { get; set; }
        public int CalisanTipi { get; set; }


    }
}
