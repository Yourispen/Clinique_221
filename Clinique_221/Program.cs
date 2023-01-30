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
            /*IRdvView rdvView= new RdvForm();
            IRdvPresenter rdvPresenter = new RdvPresenter(rdvView, Fabrique.getService());
            Application.Run(rdvView as RdvForm);*/
            /*IAjoutRdvView ajoutRdvView = new AjoutRdvForm();
            IAjoutRdvPresenter ajoutRdvPresenter = new AjoutRdvPresenter(ajoutRdvView, Fabrique.getService());
            Application.Run(ajoutRdvView as AjoutRdvForm);*/
            /*IPatientView patientView = new PatientForm();
            IPatientPresenter patientPresenter = new PatientPresenter(patientView, Fabrique.getService());
            Application.Run(patientView as PatientForm);*/
            /*IPrestationView prestationView = new PrestationForm();
            IPrestationPresenter prestationPresenter = new PrestationPresenter(prestationView, Fabrique.getService());
            Application.Run(prestationView as PrestationForm);*/
            /*IConsultationView consultationView = new ConsultationForm();
            IConsultationPresenter consultationPresenter = new ConsultationPresenter(consultationView, Fabrique.getService());
            Application.Run(consultationView as ConsultationForm);*/
            IConnexionView connexionView = new ConnexionForm();
            IConnexionPresenter connexion = new ConnexionPresenter(connexionView, Fabrique.getService());
            Application.Run(connexionView as ConnexionForm);
            /*IAjoutPrestationView ajoutPrestationView = new AjoutPrestationForm();
            IAjoutPrestationPresenter ajoutPrestationPresenter = new AjoutPrestationPresenter(ajoutPrestationView, Fabrique.getService());
            Application.Run(ajoutPrestationView as AjoutPrestationForm);*/
        }
    }
}
