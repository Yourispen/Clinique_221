using Clinique_221.Core;
using Clinique_221.Models;
using Clinique_221.Services;
using Clinique_221.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Presenter
{
    public class ConnexionPresenter : IConnexionPresenter
    {
        IConnexionView view;
        IServiceClinique serviceClinique;

        public ConnexionPresenter(IConnexionView view, IServiceClinique serviceClinique)
        {
            this.view = view;
            this.serviceClinique = serviceClinique;
            this.view.eventConnexion += connexionHandler;
            this.view.Show();
        }

        private void connexionHandler(object sender, EventArgs e)
        {
            view.Success = false;
            try
            {
                Utilisateur utilisateur = new Utilisateur()
                {
                    Email=view.TxtLogin,
                };
                utilisateur=serviceClinique.seConnecter(view.TxtLogin);
                if (utilisateur != null)
                {
                    if (utilisateur.Password == view.TxtPassword)
                    {
                        view.Success = true;
                        IHomeView menuView = new HomeForm();
                        menuView.UserConnect = utilisateur;
                        IMenuPresenter menuPresenter = new MenuPresenter(menuView,serviceClinique);
                        view.Hide();
                        //(view as ConnexionForm).Dispose();
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static ConnexionPresenter instance = null;

        public static ConnexionPresenter getInstance(IConnexionView connexionView)
        {

            if (instance == null)
            {
                instance = new ConnexionPresenter(connexionView,Fabrique.getService());

            }
            return instance;
        }
    }
}
