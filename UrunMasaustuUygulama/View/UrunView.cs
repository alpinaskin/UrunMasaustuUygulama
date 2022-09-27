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
    public partial class UrunView : Form, IUrunView
    {
        private string message;
        private bool isSucceeded;
        private bool isEdited;
        public UrunView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageUrunDetay);
            buttonExit.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonUrunAra.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textBoxUrunAra.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Ürün Ekle
            buttonUrunEkle.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                textBoxUrunId.Enabled = false;
                tabControl1.TabPages.Remove(tabUrunler);
                tabControl1.TabPages.Remove(tabPageSatilanUrunler);
                tabControl1.TabPages.Add(tabPageUrunDetay);
                tabPageUrunDetayText.Text = "Ürün Ekle";

            };

            //Ürün Düzenleme
            buttonUrunDuzenle.Click += delegate
            {
                textBoxUrunId.Enabled = false;
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabUrunler);
                tabControl1.TabPages.Remove(tabPageSatilanUrunler);
                tabControl1.TabPages.Add(tabPageUrunDetay);
                tabPageUrunDetayText.Text = "Ürün Düzenle";
            };

            //Ürün Kaydet
            buttonUrunKaydet.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSucceeded)
                {
                    tabControl1.TabPages.Remove(tabPageUrunDetay);
                    tabControl1.TabPages.Add(tabUrunler);
                    tabControl1.TabPages.Add(tabPageSatilanUrunler);
                }
                MessageBox.Show(ErrorMessage);
            };

            //Kayıt ya da Düzenleme iptal
            buttonIptal.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageUrunDetay);
                tabControl1.TabPages.Add(tabUrunler);
                tabControl1.TabPages.Add(tabPageSatilanUrunler);
            };

            //Ürün Silme
            ButtonUrunSil.Click += delegate
            {
                var result = MessageBox.Show("Ürünü silmek istiyor musunuz?", "Uyarı",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(ErrorMessage);
                }
            };
        }

        public string UrunId { get => textBoxUrunId.Text; set => textBoxUrunId.Text = value; }
        public string UrunAdi { get => textBoxUrunAdi.Text; set => textBoxUrunAdi.Text = value; }
        public double? Fiyat
        {
            get { return Double.Parse(textBoxUrunFiyat.Text); }
            set { textBoxUrunFiyat.Text = value.ToString(); }
        }
        public string Aciklama { get => richTextBoxUrunAciklamasi.Text; set => richTextBoxUrunAciklamasi.Text = value; }
        public string Renk { get => textBoxUrunRenk.Text; set => textBoxUrunRenk.Text = value; }
        public string UrunQuery { get => textBoxUrunAra.Text; set => textBoxUrunAra.Text = value; }
        public bool IsEdited { get => isEdited; set => isEdited = value; }
        public bool IsSucceeded { get => isSucceeded; set => isSucceeded = value; }
        public string ErrorMessage { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetUrunList(BindingSource urunList)
        {
            dataGridViewUrunler.DataSource = urunList;
        }

        public void SetSatilanUrunList(BindingSource satilanUrunler)
        {
            dataGridViewSatilanUrunler.DataSource = satilanUrunler;
        }

        //Singleton
        private static UrunView instance;
        public static UrunView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UrunView();
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
