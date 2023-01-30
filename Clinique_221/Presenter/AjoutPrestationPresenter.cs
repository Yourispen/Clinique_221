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
    public class AjoutPrestationPresenter : IAjoutPrestationPresenter
    {
        private IAjoutPrestationView ajoutPrestationView;
        private IServiceClinique serviceClinique;
        private Patient patientSearch;
        private IHomeView homeView;
        private Prestation prestation;

        public AjoutPrestationPresenter(IAjoutPrestationView ajoutPrestationView, IServiceClinique serviceClinique, IHomeView homeView,Prestation prestation)
        {
            this.prestation = prestation;
            this.homeView = homeView;
            this.ajoutPrestationView = ajoutPrestationView;
            this.serviceClinique = serviceClinique;

            initialise();
            callBackEvent();
            ajoutPrestationView.Show();
        }

        BindingSource bindingTypePrestationListe = new BindingSource();
        BindingSource bindingAntecedentMedicalListe = new BindingSource();

        IEnumerable<TypePrestation> typePrestationListe = new List<TypePrestation>();
        IEnumerable<AntecedentMedical> antecedentMedicalListe = new List<AntecedentMedical>();

        public void initialise()
        {
           
            //verification de la consultation
            typePrestationListe = Fabrique.getService().listerTypePrestation();
            antecedentMedicalListe = Fabrique.getService().listerAntecedentMedical();
            bindingTypePrestationListe.DataSource = typePrestationListe;
            bindingAntecedentMedicalListe.DataSource = antecedentMedicalListe;

            ajoutPrestationView.setListeTypePrestationsBindingSource(bindingTypePrestationListe);
            ajoutPrestationView.setListeAntecedentMedicalBindingSource(bindingAntecedentMedicalListe);

            ajoutPrestationView.PnlAjoutPatient.Enabled = false;

            if (this.prestation.EtatPrestation == Etat.EnAttente)
            {
                ajoutPrestationView.GboxPrestation.Enabled = true;
                ajoutPrestationView.BtnAjouter.Visible = true;

            }
            else
            {
                ajoutPrestationView.GboxPrestation.Enabled = false;
                ajoutPrestationView.BtnAjouter.Visible = false;
                ajoutPrestationView.GboxPatient.Enabled = false;
                ajoutPrestationView.TxtCode = this.prestation.Patient.Code;
                remplirInfoPatient(this.prestation.Patient);
                remplirInfoPrestation(this.prestation);
            }
        }

        public void callBackEvent()
        {
            ajoutPrestationView.eventRecherchePatientParCode += rechercherPatientHandle;
            ajoutPrestationView.eventAjouter += creerPrestationHandle;
            ajoutPrestationView.eventAnnuler += annulerHandle;
        }

        private void annulerHandle(object sender, EventArgs e)
        {
            (ajoutPrestationView as AjoutPrestationForm).Dispose();
        }

        private void creerPrestationHandle(object sender, EventArgs e)
        {
            Prestation prestation  = Fabrique.getService().ajouterPrestation(new Prestation() { 
                DatePrestation = DateTime.Now,
                EtatPrestation = Etat.Valide,
                Heure = DateTime.Now.Hour.ToString()+"H",
                Patient = patientSearch
            });
            foreach (var typePrestation in ajoutPrestationView.ChlboxListeDesPrestations.CheckedItems)
            {
                prestation.TypePrestations.Add(typePrestation as TypePrestation);
            }
            Fabrique.getService().ajouterPrestationTypePrestation(prestation);

            MessageBox.Show("Prestation créée avec succès.");
        }
        
        private void rechercherPatientHandle(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ajoutPrestationView.TxtCode))
            {
                patientSearch = Fabrique.getService().rechercherPatient(ajoutPrestationView.TxtCode);
                if (patientSearch != null)
                {
                    remplirInfoPatient(patientSearch);
                }
            }
            else
            {
                MessageBox.Show("Ce patient n'existe pas");
            }
        }
        private void remplirInfoPatient(Patient patient)
        {
            ajoutPrestationView.TxtNomComplet = patient.NomComplet;
            ajoutPrestationView.ChboxMasculin.Checked = patient.Sexe == Sexe.M;
            ajoutPrestationView.ChboxFeminin.Checked = patient.Sexe == Sexe.F;
            ajoutPrestationView.DtpDateNaissance = patient.DateNaissance;
            List<AntecedentMedical> antecedentMedicaux = patient.AntecedantMedicaux;
            for (int i = 0; i < bindingAntecedentMedicalListe.Count; i++)
            {
                ajoutPrestationView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, false);
                foreach (var antecedentMedical in antecedentMedicaux)
                {
                    if (antecedentMedical.ToString().CompareTo(bindingAntecedentMedicalListe[i].ToString()) == 0)
                    {
                        ajoutPrestationView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, true);
                        antecedentMedicaux.Remove(antecedentMedical);
                        break;
                    }
                }
            }

        }
        private void remplirInfoPrestation(Prestation prestation)
        {
            List<TypePrestation> typePrestations = serviceClinique.listerTypePrestation(this.prestation);
            for (int i = 0; i < bindingTypePrestationListe.Count; i++)
            {
                ajoutPrestationView.ChlboxListeDesPrestations.SetItemChecked(i, false);
                foreach (var typePrestation in typePrestations)
                {
                    if (typePrestation.ToString().CompareTo(bindingTypePrestationListe[i].ToString()) == 0)
                    {
                        ajoutPrestationView.ChlboxListeDesPrestations.SetItemChecked(i, true);
                        typePrestations.Remove(typePrestation);
                        break;
                    }
                }
            }
        }

    }

}

