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
    public class AjoutRdvPresenter : IAjoutRdvPresenter
    {
        private IAjoutRdvView ajoutRdvView;
        private IServiceClinique serviceClinique;
        private Patient patientSearch;

        public AjoutRdvPresenter(IAjoutRdvView ajoutRdvView, IServiceClinique serviceClinique)
        {
            this.ajoutRdvView = ajoutRdvView;
            this.serviceClinique = serviceClinique;

            initialise();
            callBackEvent();
            choisirAncienPatientHandle(ajoutRdvView, EventArgs.Empty);
            choisirPrestationHandle(ajoutRdvView, EventArgs.Empty);
            choisirSexeMasculinHandle(ajoutRdvView, EventArgs.Empty);
            choisirDateRdvHandle(ajoutRdvView, EventArgs.Empty);

        }

        BindingSource bindingTypePrestationListeListe = new BindingSource();
        BindingSource bindingMedecinListe = new BindingSource();
        BindingSource bindingAntecedentMedicalListe = new BindingSource();

        IEnumerable<TypePrestation> typePrestationListe = new List<TypePrestation>();
        IEnumerable<Medecin> medecinListe = new List<Medecin>();
        IEnumerable<AntecedentMedical> antecedentMedicalListe = new List<AntecedentMedical>();

        public void initialise()
        {
            typePrestationListe = Fabrique.getService().listerTypePrestation();
            medecinListe = Fabrique.getService().listerMedecin();
            antecedentMedicalListe= Fabrique.getService().listerAntecedentMedical();
            bindingTypePrestationListeListe.DataSource = typePrestationListe;
            bindingMedecinListe.DataSource = medecinListe;
            bindingAntecedentMedicalListe.DataSource = antecedentMedicalListe;

            ajoutRdvView.setListeTypePrestationsBindingSource(bindingTypePrestationListeListe);
            ajoutRdvView.setListeDesMedecinBindingSource(bindingMedecinListe);
            ajoutRdvView.setListeAntecedentMedicalBindingSource(bindingAntecedentMedicalListe);
        }

        public void callBackEvent()
        {
            ajoutRdvView.eventNouveauPatient += choisirNouveauPatientHandle;
            ajoutRdvView.eventAncienPatient += choisirAncienPatientHandle;
            ajoutRdvView.eventChoixTypePrestation += choisirPrestationHandle;
            ajoutRdvView.eventChoixTypeConsultation += choisirConsultationHandle;
            ajoutRdvView.eventChoixSexeFemininPatient += choisirSexeFemininHandle;
            ajoutRdvView.eventChoixSexeMasculinPatient += choisirSexeMasculinHandle;
            ajoutRdvView.eventChoixDateRdv += choisirDateRdvHandle;
            ajoutRdvView.eventRecherchePatientParCode += rechercherPatientHandle;
            ajoutRdvView.eventAjouterDemandeRdv += creerRdvHandle;
            ajoutRdvView.eventAnnulerDemandeRdv += annulerDemandeRdvHandle;
        }

        private void annulerDemandeRdvHandle(object sender, EventArgs e)
        {
            (ajoutRdvView as AjoutRdvForm).Dispose();
        }

        private void creerRdvHandle(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                NomComplet = ajoutRdvView.TxtNomComplet,
                Sexe = (Sexe)Enum.Parse(typeof(Sexe), ajoutRdvView.ChboxFeminin.Checked?Sexe.F.ToString(): Sexe.M.ToString()),
                DateNaissance = ajoutRdvView.DtpDateNaissance,
                NomParent = ajoutRdvView.TxtNomParent,
                TypePatient = (TypePatient)Enum.Parse(typeof(TypePatient), "Adulte"),
                Code="PAT00003"
            };
            foreach (var antMed in ajoutRdvView.ChlboxListeDesAntecedentsMedicaux.CheckedItems)
            {
                patient.AntecedantMedicaux.Add(antMed as AntecedentMedical);
            }
            patient = recupererPatient(patient);
            Fabrique.getService().ajouterAntecedentMedicalUnPatient(patient, patient.AntecedantMedicaux);
            Rdv rdv = new Rdv()
            {
                Patient = patient,
                TypeRdv = (TypeRdv)Enum.Parse(typeof(TypeRdv), ajoutRdvView.ChboxConsultation.Checked ? TypeRdv.Consultation.ToString() : TypeRdv.Prestation.ToString()),
                DateRdv = ajoutRdvView.DtpDateRdv,
            };
            if (ajoutRdvView.ChboxConsultation.Checked)
            {
                rdv.Medecin = bindingMedecinListe.Current as Medecin;
            }
            else
            {
                foreach (var typePrestation in ajoutRdvView.ChlboxListeDesPrestations.CheckedItems)
                {
                    ///patient.
                }
            }
            viderInfoPatient();

        }
        private Patient recupererPatient(Patient patient)
        {
            if (ajoutRdvView.ChboxNouveauPatient.Checked)
            {
                return Fabrique.getService().ajouterPatient(patient);
            }
            else
            {
                return patientSearch;
            }
        }

        private void choisirNouveauPatientHandle(object sender, EventArgs e)
        {
            viderInfoPatient();
            bool check = ajoutRdvView.ChboxNouveauPatient.Checked;
            ajoutRdvView.ChboxAncienPatient.Checked = !check;
            ajoutRdvView.PnlRechercherPatient.Enabled = !check;
            ajoutRdvView.PnlAjoutPatient.Enabled = check;
        }
        private void choisirAncienPatientHandle(object sender, EventArgs e)
        {
            viderInfoPatient();
            bool check = ajoutRdvView.ChboxAncienPatient.Checked;
            ajoutRdvView.ChboxNouveauPatient.Checked = !check;
            ajoutRdvView.PnlRechercherPatient.Enabled = check;
            ajoutRdvView.PnlAjoutPatient.Enabled = !check;
        }
        private void choisirPrestationHandle(object sender, EventArgs e)
        {
            bool check = ajoutRdvView.ChboxPrestation.Checked;
            ajoutRdvView.ChboxConsultation.Checked = !check;
            ajoutRdvView.LblMedecin.Visible = !check;
            ajoutRdvView.CboxListeDesMedecin.Visible = !check;
        }
        private void choisirConsultationHandle(object sender, EventArgs e)
        {
            bool check = ajoutRdvView.ChboxConsultation.Checked;
            ajoutRdvView.ChboxPrestation.Checked = !check;
            ajoutRdvView.LblListePrestation.Visible = !check;
            ajoutRdvView.ChlboxListeDesPrestations.Visible = !check;
        }
        private void choisirSexeMasculinHandle(object sender, EventArgs e)
        {
            ajoutRdvView.ChboxFeminin.Checked = !ajoutRdvView.ChboxMasculin.Checked;
        }
        private void choisirSexeFemininHandle(object sender, EventArgs e)
        {
            ajoutRdvView.ChboxMasculin.Checked = !ajoutRdvView.ChboxFeminin.Checked;
        }
        private void choisirDateRdvHandle(object sender, EventArgs e)
        {

        }
        private void rechercherPatientHandle(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ajoutRdvView.TxtCode)) 
            {
                patientSearch = Fabrique.getService().rechercherPatient(ajoutRdvView.TxtCode);
                if(patientSearch != null)
                {
                    remplirInfoPatient(patientSearch);
                }
            }
        }
        private void remplirInfoPatient(Patient patient)
        {
            ajoutRdvView.TxtNomComplet = patient.NomComplet;
            ajoutRdvView.ChboxMasculin.Checked = patient.Sexe == Sexe.M;
            ajoutRdvView.ChboxFeminin.Checked = patient.Sexe == Sexe.F;
            ajoutRdvView.DtpDateNaissance = patient.DateNaissance;
            ajoutRdvView.TxtNomParent = patient.NomParent;
            List<AntecedentMedical> antecedentMedicaux = patient.AntecedantMedicaux;
            for (int i=0;i< bindingAntecedentMedicalListe.Count;i++)
            {
                ajoutRdvView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, false);
                foreach (var antecedentMedical in antecedentMedicaux)
                {
                    if (antecedentMedical.ToString().CompareTo(bindingAntecedentMedicalListe[i].ToString()) == 0)
                    {
                        ajoutRdvView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, true);
                        antecedentMedicaux.Remove(antecedentMedical);
                        break;
                    }
                }
            }
            
        }
        private void viderInfoPatient()
        {
            ajoutRdvView.TxtNomComplet="";
            ajoutRdvView.ChboxMasculin.Checked = false;
            ajoutRdvView.ChboxFeminin.Checked = true;
            ajoutRdvView.DtpDateNaissance = DateTime.Now;
            ajoutRdvView.TxtNomParent = "";
            patientSearch = null;
            for (int i = 0; i < bindingAntecedentMedicalListe.Count; i++)
            {
                ajoutRdvView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, false);
            }
        }

    }
}
