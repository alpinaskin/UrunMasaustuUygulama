using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunMasaustuUygulama.Dto;

namespace UrunMasaustuUygulama.Model.Repository
{
    public interface IUrunRepository
    {
        void Add(Urun urun);
        void Edit(Urun urun);
        void Delete(ulong id);
        IEnumerable<Urun> GetAll();
        IEnumerable<Urun> GetByUrunAdi(string UrunAdi);
        IEnumerable<SatilanUrun> GetAllSatilanUrun();
    }
}
