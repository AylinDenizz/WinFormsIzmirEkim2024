﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiFormu
{
    public enum Cinsiyet { Erkek = 0, Kadın = 1, NonBinary = 2 };
    public enum CalısanTipi { Yonetici = 0, BeyazYaka = 1, GriYaka = 2, MaviYaka = 3 };

    [Flags]
    public enum Gunler
    {
        CALISMIYOR = 0, PZT = 1, SAL = 2, CAR = 4, PER = 8, CUM = 16, CMT = 32, PAZ = 64,
        HAFTAICI = PZT | SAL | CAR | PER | CUM,
        HAFTASONU = CMT | PAZ
    }

    public enum PersonelDurumu {
            SureliSözlesmeli = 0, kadrolu = 1,
            PartTime = 2, Stajyer = 3 
    };
}
