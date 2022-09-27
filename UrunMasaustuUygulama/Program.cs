using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunMasaustuUygulama.Model.Repository;
using UrunMasaustuUygulama.Presenter;
using UrunMasaustuUygulama.Repository;
using UrunMasaustuUygulama.View;

namespace UrunMasaustuUygulama
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView mainView = new MainView();
            new MainPresenter(mainView, sqlConnectionString);
            Application.Run((Form)mainView);
        }
    }
}
