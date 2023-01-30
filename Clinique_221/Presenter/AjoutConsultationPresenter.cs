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
    public class AjoutConsultationPresenter : IAjoutConsultationPresenter
    {
        private IAjoutConsultationView ajoutConsultationView;
        private IServiceClinique serviceClinique;
        private Patient patientSearch;
        private IHomeView homeView;
        private Consultation consultation;

        public AjoutConsultationPresenter(IAjoutConsultationView ajoutConsultationView, IServiceClinique serviceClinique, IHomeView homeView,Consultation consultation)
        {
            this.homeView = homeView;
            this.consultation = consultation;
            this.ajoutConsultationView = ajoutConsultationView;
            this.serviceClinique = serviceClinique;

            initialise();
            callBackEvent();
            choisirAvecOrdonnanceHandle(ajoutConsultationView, EventArgs.Empty);
            if (this.consultation.EtatConsultation == Etat.EnAttente)
            {
                ajoutConsultationView.GboxConsultation.Enabled = true;
                ajoutConsultationView.BtnAjouter.Visible = true;
            }
            else
            {
                ajoutConsultationView.GboxConsultation.Enabled = false;
                ajoutConsultationView.BtnAjouter.Visible = false;
                ajoutConsultationView.GboxPatient.Enabled = false;
                ajoutConsultationView.TxtCode = this.consultation.Patient.Code;
                remplirInfoPatient(this.consultation.Patient);
                remplirInfoConsultation(this.consultation);
            }
            ajoutConsultationView.Show();
        }

        BindingSource bindingAntecedentMedicalListe = new BindingSource();
        BindingSource bindingMedicamentListe = new BindingSource();

        IEnumerable<AntecedentMedical> antecedentMedicalListe = new List<AntecedentMedical>();
        IEnumerable<Medicament> medicamentListe = new List<Medicament>();

        public void initialise()
        {
            //verification de la consultation
            antecedentMedicalListe = Fabrique.getService().listerAntecedentMedical();
            //medicamentListe= Fabrique.getService().listerMedicament();
            bindingAntecedentMedicalListe.DataSource = antecedentMedicalListe;
            bindingMedicamentListe.DataSource = medicamentListe;

            ajoutConsultationView.setListeAntecedentMedicalBindingSource(bindingAntecedentMedicalListe);
            ajoutConsultationView.setListeMedicamentBindingSource(bindingMedicamentListe);

            ajoutConsultationView.PnlAjoutPatient.Enabled = false;

        }

        public void callBackEvent()
        {
            ajoutConsultationView.eventRecherchePatientParCode += rechercherPatientHandle;
            ajoutConsultationView.eventAjouter += creerConsultationHandle;
            ajoutConsultationView.eventAnnuler += annulerHandle;
            ajoutConsultationView.eventAvecOrdonnance += choisirAvecOrdonnanceHandle;
            ajoutConsultationView.eventSansOrdonnance += choisirSansOrdonnanceHandle;
            ajoutConsultationView.eventAjouterMedicament += ajouterMedicamentHandle;
            ajoutConsultationView.eventSupprimerMedicament += supprimerMedicamentHandle;
        }

        private void supprimerMedicamentHandle(object sender, EventArgs e)
        {
            if (bindingMedicamentListe.Current != null)
            {
                bindingMedicamentListe.Remove(bindingMedicamentListe.Current as Medicament);
            }
        }

        private void ajouterMedicamentHandle(object sender, EventArgs e)
        {
            Medicament medicament = serviceClinique.rechercherMedicament(ajoutConsultationView.TxtCodeMedicament);
            if(medicament != null)
            {
                bindingMedicamentListe.Add(medicament);
            }
            else
            {
                MessageBox.Show("Ce medicament n'existe pas.");
            }
        }

        private void choisirSansOrdonnanceHandle(object sender, EventArgs e)
        {
            bool check = ajoutConsultationView.ChboxSans.Checked;
            ajoutConsultationView.ChboxAvec.Checked = !check;
            ajoutConsultationView.PnlMedicament.Enabled = !check;
        }

        private void choisirAvecOrdonnanceHandle(object sender, EventArgs e)
        {
            bool check = ajoutConsultationView.ChboxAvec.Checked;
            ajoutConsultationView.ChboxSans.Checked = !check;
            ajoutConsultationView.PnlMedicament.Enabled = check;
        }

        private void annulerHandle(object sender, EventArgs e)
        {
            (ajoutConsultationView as AjoutConsultationForm).Dispose();
        }

        private void creerConsultationHandle(object sender, EventArgs e)
        {
            //Utilisateur utilisateur = homeView.UserConnect;
            //utilisateur = 
            Consultation consultation = new Consultation()
            {
                DateConsultation = DateTime.Now,
                EtatConsultation = Etat.Valide,
                Heure = DateTime.Now.Hour.ToString() + "H",
                Patient = patientSearch,
                Medecin = serviceClinique.rechercherMedecin(homeView.UserConnect.Id)
            } ;
            if (ajoutConsultationView.ChboxAvec.Checked)
            {
                Ordonnance ordonnance = new Ordonnance()
                {
                    DateOrdonnance = DateTime.Now
                };
                ordonnance = serviceClinique.ajouterOrdonnance(ordonnance);
                List<Medicament> medicaments = new List<Medicament>();
                foreach (var medicament in bindingMedicamentListe.List)
                {
                    medicaments.Add(medicament as Medicament);
                }
                serviceClinique.ajouterOrdonnanceMedicaments(ordonnance.Id, medicaments);
                consultation.Ordonnance = ordonnance;

            }
            Fabrique.getService().ajouterConsultation(consultation);

            MessageBox.Show("Consultation créée avec succès.");
        }

        private void rechercherPatientHandle(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ajoutConsultationView.TxtCode))
            {
                patientSearch = Fabrique.getService().rechercherPatient(ajoutConsultationView.TxtCode);
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
            ajoutConsultationView.TxtNomComplet = patient.NomComplet;
            ajoutConsultationView.ChboxMasculin.Checked = patient.Sexe == Sexe.M;
            ajoutConsultationView.ChboxFeminin.Checked = patient.Sexe == Sexe.F;
            ajoutConsultationView.DtpDateNaissance = patient.DateNaissance;
            List<AntecedentMedical> antecedentMedicaux = patient.AntecedantMedicaux;
            for (int i = 0; i < bindingAntecedentMedicalListe.Count; i++)
            {
                ajoutConsultationView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, false);
                foreach (var antecedentMedical in antecedentMedicaux)
                {
                    if (antecedentMedical.ToString().CompareTo(bindingAntecedentMedicalListe[i].ToString()) == 0)
                    {
                        ajoutConsultationView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, true);
                        antecedentMedicaux.Remove(antecedentMedical);
                        break;
                    }
                }
            }

        }
        private void remplirInfoConsultation(Consultation consultation)
        {
            if (consultation.Ordonnance != null)
            {
                ajoutConsultationView.ChboxAvec.Checked = true;
                medicamentListe = serviceClinique.listerMedicament(consultation.Ordonnance);
                bindingMedicamentListe.DataSource = medicamentListe;
            }
        }

    }
}
