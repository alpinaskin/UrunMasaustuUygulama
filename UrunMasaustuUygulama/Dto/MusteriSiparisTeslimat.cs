using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UrunMasaustuUygulama.Dto
{
    public class MusteriSiparisTeslimat
    {
        private string urunAdi;
        private uint urunAdet;
        private string teslimatAdres;
        private string postaKodu;

        [DisplayName("Ürün Adı")]
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        [DisplayName("Ürün Adeti")]
        public uint UrunAdet { get => urunAdet; set => urunAdet = value; }
        [DisplayName("Teslimat Adresi")]
        public string TeslimatAdres { get => teslimatAdres; set => teslimatAdres = value; }
        [DisplayName("Posta Kodu")]
        public string PostaKodu { get => postaKodu; set => postaKodu = value; }
    }
}
