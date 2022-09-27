using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunMasaustuUygulama.Model;

namespace UrunMasaustuUygulama.View
{
    public interface IMusteriView
    {
        Musteri SelectedMusteri { get; set; }
        string musteriQuery { get; set; }
        string ErrorMessage { get; set; }

        event EventHandler SearchEvent;
        event EventHandler CancelEvent;
        event EventHandler MusteriAlinanUrunlerEvent;

        void SetMusteriList(BindingSource musteriList);
        void SetMusteriSiparisList(BindingSource musteriSiparisList);
        void Show();
    }
}
