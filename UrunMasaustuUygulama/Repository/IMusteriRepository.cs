using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunMasaustuUygulama.Dto;
using UrunMasaustuUygulama.Model;

namespace UrunMasaustuUygulama.Repository
{
    public interface IMusteriRepository
    {
        IEnumerable<Musteri> GetAll();
        IEnumerable<Musteri> GetByMusteriAdi(string musteriAdi);
        Musteri GetByMusteriId(ulong musteriId);
        IEnumerable<MusteriSiparisTeslimat> GetMusteriSiparisByMusteriId(ulong musteriId);
    }
}
