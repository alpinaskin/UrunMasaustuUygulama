using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunMasaustuUygulama.View
{
    public interface IUrunView
    {
        string UrunId { get; set; }
        string UrunAdi { get; set; }
        double? Fiyat { get; set; }
        string Aciklama { get; set; }
        string Renk { get; set; }

        string UrunQuery { get; set; }
        bool IsEdited { get; set; }
        bool IsSucceeded { get; set; }
        string ErrorMessage { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetUrunList(BindingSource urunList);
        void SetSatilanUrunList(BindingSource satilanUrunList);
        void Show();
    }
}
