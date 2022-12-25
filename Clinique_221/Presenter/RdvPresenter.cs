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
    public class RdvPresenter:IRdvPresenter
    {
        //Dependance et couplage faible
        private IRdvView rdvView;
        private IServiceClinique serviceClinique;

        //Injection de dependance et inversion de controle
        public RdvPresenter(IRdvView rdvView, IServiceClinique serviceClinique)
        {
            this.rdvView = rdvView;
            this.serviceClinique = serviceClinique;

            this.initialise();
            this.callBackEvent();
        }
        //BindingSource
        BindingSource bindingRdvListe = new BindingSource();

        //Liste
        IEnumerable<Rdv> rdvListe = new List<Rdv>();

        public void initialise()
        {
            rdvListe = Fabrique.getService().listerRdv();
            bindingRdvListe.DataSource = rdvListe;

            this.rdvView.setRdvBindingSource(bindingRdvListe);
        }

        //definir les fonctions de rappel(callback)
        public void callBackEvent()
        {
            rdvView.eventAjouterRdv += ajouterRdvHandle;
            rdvView.eventRecherchePatient += rechercherPatientHandle;
            rdvView.eventAnnulerRdv += annulerRdvHandle;
            rdvView.eventValiderRdv += validerRdvHandle;
        }

        private void validerRdvHandle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void annulerRdvHandle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void rechercherPatientHandle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ajouterRdvHandle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
