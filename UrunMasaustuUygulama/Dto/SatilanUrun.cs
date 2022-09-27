using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UrunMasaustuUygulama.Dto
{
    public class SatilanUrun
    {
        private string urunAdi;
        private int satilanAdet;
        private decimal toplamFiyat;

        [DisplayName("Satılan Ürün Adı")]
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        [DisplayName("Satılan Ürün Adeti")]
        public int SatilanAdet { get => satilanAdet; set => satilanAdet = value; }
        [DisplayName("Toplam Fiyat")]
        public decimal ToplamFiyat { get => toplamFiyat; set => toplamFiyat = value; }
    }
}
