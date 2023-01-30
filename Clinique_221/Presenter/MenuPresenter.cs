using Clinique_221.Core;
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
    public class MenuPresenter : IMenuPresenter
    {
        private IHomeView homeView;
        private IServiceClinique serviceClinique;

        public MenuPresenter(IHomeView homeView, IServiceClinique serviceClinique)
        {
            this.homeView = homeView;
            this.serviceClinique = serviceClinique;

            callBackEvent();
            initialise();
            this.homeView.Show();
            LoadRdv();
        }

        public void initialise()
        {
            homeView.LblCompte="Mon Compte("+homeView.UserConnect.NomComplet+")";
            if (homeView.UserConnect.Role == Models.Role.Rp)
            {
                homeView.BtnConsultation.Visible = false;
                homeView.BtnPatient.Visible = false;
            }
            else if (homeView.UserConnect.Role == Models.Role.Medecin)
            {
                homeView.BtnPrestation.Visible = false;

            }
            else if (homeView.UserConnect.Role == Models.Role.Secretaire)
            {
                homeView.BtnPrestation.Visible = false;
                homeView.BtnConsultation.Visible = false;
                homeView.BtnPatient.Visible = false;
            }
        }
        public void LoadRdv()
        {
            homeView.LblTitrePage = "Gestion des rendez-vous";
            IRdvView rdvView =RdvForm.getInstance(homeView as Form);
            new RdvPresenter(rdvView, Fabrique.getService(),homeView);
        }
        public void loadPatient()
        {
            IPatientView patientView = PatientForm.getInstance(homeView as Form);
            new PatientPresenter(patientView, Fabrique.getService());
        }
        public void loadPrestation()
        {
            IPrestationView prestationView = PrestationForm.getInstance(homeView as Form);
            new PrestationPresenter(prestationView, Fabrique.getService(),homeView);
        }
        public void LoadConsultation()
        {
            IConsultationView consultationView = ConsultationForm.getInstance(homeView as Form);
            new ConsultationPresenter(consultationView, Fabrique.getService(),homeView);
        }

        public void callBackEvent()
        {
            homeView.eventShowRdv += showRdvViewHandler;
            homeView.eventShowPatient += showPatientViewtHandler;
            homeView.eventShowPrestation += showPrestationViewHandler;
            homeView.eventShowConsultation += showConsultationViewHandler;
            homeView.eventDeconnexionView += deconnexionHandler;
        }

        private void deconnexionHandler(object sender, EventArgs e)
        {
            //IConnexionView connexionView = ConnexionForm.getInstance();
            //new ConnexionPresenter(connexionView, Fabrique.getService());
            IConnexionView connexionView = new ConnexionForm();
            new ConnexionPresenter(connexionView, Fabrique.getService());
            (homeView as HomeForm).Dispose();
        }

        private void showConsultationViewHandler(object sender, EventArgs e)
        {
            homeView.LblTitrePage = "Gestion des consultations";
            LoadConsultation();
        }

        private void showPrestationViewHandler(object sender, EventArgs e)
        {
            homeView.LblTitrePage = "Gestion des prestations";
            loadPrestation();
        }

        private void showPatientViewtHandler(object sender, EventArgs e)
        {
            homeView.LblTitrePage = "Gestion des patients";
            loadPatient();
        }

        private void showRdvViewHandler(object sender, EventArgs e)
        {
            LoadRdv();
        }

        private void showViewHandler(object sender, EventArgs e)
        {

            //if(homeView as Form)
           /* switch (switch_on)
            {
                default:
            }*/
        }
    }
}
