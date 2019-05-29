using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2._3._3
{
    class KimyasalUrunler
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunHammaddeleri { get; set; }
        public int HammaddeMiktari { get; set; }
        public string UretimTarihi { get; set; }
        public int RafOmru { get; set; }
        public decimal IscilikMaliyeti { get; set; }
        public decimal ToplamMaliyet { get; set; }
        public decimal SatisFiyati { get; set; }
    }
}
