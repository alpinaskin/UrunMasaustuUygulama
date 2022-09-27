using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunMasaustuUygulama.Model;

namespace UrunMasaustuUygulama.View
{
    public partial class MusteriView : Form, IMusteriView
    {
        private string message;
        private Musteri selectedMusteri;
        public MusteriView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageAlinanUrunler);
            btnExit.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Seçili Müşterinin Aldığı Ürünleri Getir
            buttonAlinanUrunler.Click += delegate
            {
                MusteriAlinanUrunlerEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageMusteriler);
                tabControl1.TabPages.Add(tabPageAlinanUrunler);

            };
            //Müşteri Arama
            buttonUrunAra.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtBoxMusteriAra.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Alınan Ürünler Sekmesinden Geri Gelme
            buttonIptal.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageAlinanUrunler);
                tabControl1.TabPages.Add(tabPageMusteriler);
            };
        }

        public Musteri SelectedMusteri { get => selectedMusteri; set => selectedMusteri = value; }
        public string musteriQuery { get => txtBoxMusteriAra.Text; set => txtBoxMusteriAra.Text = value; }
        public string ErrorMessage { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler MusteriAlinanUrunlerEvent;
        public event EventHandler CancelEvent;

        public void SetMusteriList(BindingSource musteriList)
        {
            dataGridViewMusteriler.DataSource = musteriList;
        }

        public void SetMusteriSiparisList(BindingSource musteriSiparisList)
        {
            dataGridViewAlinanUrunler.DataSource = musteriSiparisList;
        }

        //Singleton
        private static MusteriView instance;
        public static MusteriView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MusteriView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

    }
}
