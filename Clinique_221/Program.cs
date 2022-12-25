using Clinique_221.Core;
using Clinique_221.Presenter;
using Clinique_221.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Création des objets
            IRdvView view= new RdvForm();
            IRdvPresenter rdvPresenter = new RdvPresenter(view,Fabrique.getService());
            Application.Run(view as RdvForm);
        }
    }
}
