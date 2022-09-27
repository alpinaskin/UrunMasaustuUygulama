using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunMasaustuUygulama.Dto;
using UrunMasaustuUygulama.Model;
using UrunMasaustuUygulama.Model.Repository;
using UrunMasaustuUygulama.Presenter.Validation;
using UrunMasaustuUygulama.View;

namespace UrunMasaustuUygulama.Presenter
{
    public class UrunPresenter
    {
        private IUrunView view;
        private IUrunRepository repository;
        private BindingSource urunBindingSource, satilanUrunBindingSource;
        private IEnumerable<Urun> urunList;
        private IEnumerable<SatilanUrun> satilanUrunList;

        public UrunPresenter(IUrunView urunView, IUrunRepository urunRepository)
        {
            this.urunBindingSource = new BindingSource();
            this.satilanUrunBindingSource = new BindingSource();
            this.view = urunView;
            this.repository = urunRepository;

            this.view.SearchEvent += SearchUrun;
            this.view.AddNewEvent += AddNewUrun;
            this.view.EditEvent += LoadSelectedUrunToEdit;
            this.view.DeleteEvent += DeleteUrun;
            this.view.SaveEvent += SaveUrun;
            this.view.CancelEvent += CancelSelection;

            this.view.SetUrunList(urunBindingSource);
            this.view.SetSatilanUrunList(satilanUrunBindingSource);
            LoadAllUrunList();
            LoadAllSatilanUrunList();
            this.view.Show();

        }

        private void CancelSelection(object sender, EventArgs e)
        {
            Clean();
        }

        private void SaveUrun(object sender, EventArgs e)
        {
            var urun = new Urun();
            if(!String.IsNullOrEmpty(view.UrunId))
                urun.Id = Convert.ToUInt64(view.UrunId);
            urun.Aciklama = view.Aciklama;
            urun.Fiyat = view.Fiyat;
            urun.Renk = view.Renk;
            urun.UrunAdi = view.UrunAdi;

            try
            {
                new ModelValidation().Validate(urun);

                if (view.IsEdited)//Edit model
                {
                    repository.Edit(urun);
                    view.ErrorMessage = "Ürün Düzenlendi";
                }
                else //Add new model
                {
                    repository.Add(urun);
                    view.ErrorMessage = "Ürün Eklendi";
                }
                view.IsSucceeded = true;
                LoadAllUrunList();
                //CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSucceeded = false;
                view.ErrorMessage = ex.Message;
            }
        }

        private void DeleteUrun(object sender, EventArgs e)
        {
            try
            {
                var urun = (Urun)urunBindingSource.Current;
                repository.Delete(urun.Id);
                view.IsSucceeded = true;
                view.ErrorMessage = "Ürün Silindi!";
                LoadAllUrunList();
            }
            catch (Exception ex)
            {
                view.IsSucceeded = false;
                view.ErrorMessage = "Ürün Silinemiyor!";
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void LoadSelectedUrunToEdit(object sender, EventArgs e)
        {
            var urun = (Urun)urunBindingSource.Current;
            view.UrunId = urun.Id.ToString();
            view.UrunAdi = urun.UrunAdi;
            view.Renk = urun.Renk;
            view.Aciklama = urun.Aciklama;
            view.Fiyat = urun.Fiyat;
            view.IsEdited = true;
        }

        private void LoadAllUrunList()
        {
            urunList = repository.GetAll();
            urunBindingSource.DataSource = urunList;
        }

        private void LoadAllSatilanUrunList()
        {
            satilanUrunList = repository.GetAllSatilanUrun();
            satilanUrunBindingSource.DataSource = satilanUrunList;
        }

        private void SearchUrun(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.UrunQuery);
            if (emptyValue == false)
                urunList = repository.GetByUrunAdi(this.view.UrunQuery);
            else urunList = repository.GetAll();
            urunBindingSource.DataSource = urunList;
        }

        private void AddNewUrun(object sender, EventArgs e)
        {
            view.IsEdited = false;
        }

        private void Clean()
        {
            view.UrunId = string.Empty;
            view.UrunAdi = string.Empty;
            view.Renk = string.Empty;
            view.Fiyat = null;
            view.Aciklama = string.Empty;
        }
    }
}
