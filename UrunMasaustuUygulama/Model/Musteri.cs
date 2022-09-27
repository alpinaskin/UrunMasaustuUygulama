using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UrunMasaustuUygulama.Model
{
    public class Musteri
    {
        private ulong id;
        private string ad;
        private string soyad;
        private string eposta;
        private string telefon;

        public ulong Id { get => id; set => id = value; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "İsim 3 karakterden büyük olmalı!")]
        [Required]
        [DisplayName("Müşteri Adı")]
        public string Ad { get => ad; set => ad = value; }
        [Required]
        [DisplayName("Müşteri Soyadı")]
        public string Soyad { get => soyad; set => soyad = value; }
        [EmailAddress]
        [DisplayName("E-Posta")]
        public string Eposta { get => eposta; set => eposta = value; }
        [Phone]
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
