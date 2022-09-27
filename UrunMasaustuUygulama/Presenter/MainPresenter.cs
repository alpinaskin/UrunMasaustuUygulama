using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunMasaustuUygulama.Model.Repository;
using UrunMasaustuUygulama.Repository;
using UrunMasaustuUygulama.View;

namespace UrunMasaustuUygulama.Presenter
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowUrunView += ShowUrunView;
            this.mainView.ShowMusteriView += ShowMusteriView;
        }
        private void ShowUrunView(object sender, EventArgs e)
        {
            IUrunView urunView = UrunView.GetInstance((MainView)mainView);
            IUrunRepository urunRepository = new UrunRepository(sqlConnectionString);
            new UrunPresenter(urunView, urunRepository);
        }
        private void ShowMusteriView(object sender, EventArgs e)
        {
            IMusteriView musteriView = MusteriView.GetInstance((MainView)mainView);
            IMusteriRepository musteriRepository = new MusteriRepository(sqlConnectionString);
            new MusteriPresenter(musteriView, musteriRepository);
        }
    }
}
