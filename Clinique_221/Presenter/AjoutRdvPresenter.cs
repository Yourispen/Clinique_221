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
    public class AjoutRdvPresenter:IAjoutRdvPresenter
    {
        private IAjoutRdvView ajoutRdvView;
        private IServiceClinique serviceClinique;

        public AjoutRdvPresenter(IAjoutRdvView ajoutRdvView, IServiceClinique serviceClinique)
        {
            this.ajoutRdvView = ajoutRdvView;
            this.serviceClinique = serviceClinique;

            this.initialise();
            this.callBackEvent();
            choisirAncienPatientHandle(ajoutRdvView, EventArgs.Empty);

        }

        BindingSource bindingTypePrestationListeListe = new BindingSource();
        BindingSource bindingMedecinListe = new BindingSource();
        BindingSource bindingAntecedentMedicalListe = new BindingSource();

        IEnumerable<TypePrestation> typePrestationListe = new List<TypePrestation>();
        IEnumerable<Medecin> medecinListe = new List<Medecin>();

        public void initialise()
        {
            typePrestationListe = Fabrique.getService().listerTypePrestation();
            medecinListe = Fabrique.getService().listerMedecin();
            bindingTypePrestationListeListe.DataSource = typePrestationListe;
            bindingMedecinListe.DataSource = medecinListe;

            this.ajoutRdvView.setListeTypePrestationsBindingSource(bindingTypePrestationListeListe);
            this.ajoutRdvView.setListeDesMedecinBindingSource(bindingMedecinListe);

            this.ajoutRdvView.LblMedecin.Visible = false;
            this.ajoutRdvView.CboxListeDesMedecin.Visible = false;
            //this.ajoutRdvView.LblListePrestation.Visible = false;
            //this.ajoutRdvView.ChlboxListeDesPrestations.Visible = false;
            //this.ajoutRdvView.ChboxNouveauPatient.
        }

        public void callBackEvent()
        {
            ajoutRdvView.eventNouveauPatient += choisirNouveauPatientHandle;
            ajoutRdvView.eventAncienPatient += choisirAncienPatientHandle  ;
        }

        private void choisirNouveauPatientHandle(object sender, EventArgs e)
        {
            bool check = ajoutRdvView.ChboxNouveauPatient.Checked;
            ajoutRdvView.ChboxAncienPatient.Checked = !check;
            ajoutRdvView.PnlRechercherPatient.Enabled = !check;
            ajoutRdvView.PnlAjoutPatient.Enabled = check;
        }
        private void choisirAncienPatientHandle(object sender, EventArgs e)
        {
            bool check = ajoutRdvView.ChboxAncienPatient.Checked;
            ajoutRdvView.ChboxNouveauPatient.Checked = !check;
            ajoutRdvView.PnlRechercherPatient.Enabled = check;
            ajoutRdvView.PnlAjoutPatient.Enabled = !check;
        }
    }
}
