using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunMasaustuUygulama.View
{
    public interface IMainView
    {
        event EventHandler ShowUrunView;
        event EventHandler ShowMusteriView;
    }
}
