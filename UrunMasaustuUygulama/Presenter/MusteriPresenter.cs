using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunMasaustuUygulama.Model;
using UrunMasaustuUygulama.Repository;
using UrunMasaustuUygulama.View;

namespace UrunMasaustuUygulama.Presenter
{
    public class MusteriPresenter
    {
        private IMusteriView musteriView;
        private IMusteriRepository musteriRepository;
        private BindingSource musteriBindingSource, musteriSiparisBindingSource;
        private IEnumerable<Musteri> musteriList;

        public MusteriPresenter(IMusteriView musteriView, IMusteriRepository musteriRepository)
        {
            this.musteriView = musteriView;
            this.musteriRepository = musteriRepository;
            this.musteriBindingSource = new BindingSource();
            this.musteriSiparisBindingSource = new BindingSource();

            this.musteriView.SearchEvent += SearchMusteri;
            this.musteriView.MusteriAlinanUrunlerEvent += SetMusteriSiparis;

            this.musteriView.SetMusteriList(musteriBindingSource);
            LoadAllMusteriList();

            this.musteriView.Show();
        }

        private void LoadAllMusteriList()
        {
            var musteriList = this.musteriRepository.GetAll();
            this.musteriBindingSource.DataSource = musteriList; 
        }

        private void SearchMusteri(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.musteriView.musteriQuery);
            if (emptyValue == false)
                musteriList = musteriRepository.GetByMusteriAdi(this.musteriView.musteriQuery);
            else musteriList = musteriRepository.GetAll();
            musteriBindingSource.DataSource = musteriList;
        }
        private void SetMusteriSiparis(object sender, EventArgs e)
        {
            this.musteriView.SetMusteriSiparisList(musteriSiparisBindingSource);
            var musteri = (Musteri)this.musteriBindingSource.Current;
            SetSelectedMusteri(musteri);
            var musteriSiparisList = this.musteriRepository.GetMusteriSiparisByMusteriId(musteri.Id);
            this.musteriSiparisBindingSource.DataSource = musteriSiparisList;
        }
        private void SetSelectedMusteri(Musteri musteri)
        {
            this.musteriView.SelectedMusteri = musteri;
        }
        private void Clean()
        {
            musteriView.SelectedMusteri = null;
        }
    }
}
