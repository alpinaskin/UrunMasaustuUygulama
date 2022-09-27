using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunMasaustuUygulama.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            buttonUrun.Click += delegate { ShowUrunView?.Invoke(this, EventArgs.Empty); };
            buttonMusteri.Click += delegate { ShowMusteriView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowUrunView;
        public event EventHandler ShowMusteriView;
    }
}
