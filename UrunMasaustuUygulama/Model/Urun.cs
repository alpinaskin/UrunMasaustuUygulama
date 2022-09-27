using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UrunMasaustuUygulama.Model
{
    public class Urun
    {
        private ulong id;
        private string urunAdi;
        private string aciklama;
        private double? fiyat;
        private string renk;

        public ulong Id { get => id; set => id = value; }
        [DisplayName("Ürün Adı")]
        [Required(ErrorMessage = "Ürün Adı Zorunludur!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Ürün İsmi 3 ile 100 karakter arası olmalı!")]
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        [DisplayName("Açıklama")]
        public string Aciklama { get => aciklama; set => aciklama = value; }
        [Required(ErrorMessage = "Fiyat Zorunludur!")]
        public double? Fiyat { get => fiyat; set => fiyat = value; }
        public string Renk { get => renk; set => renk = value; }
    }
}
