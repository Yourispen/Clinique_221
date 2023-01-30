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

            ajoutRdvView.Show();

        }

        BindingSource bindingTypePrestationListeListe = new BindingSource();
        BindingSource bindingMedecinListe = new BindingSource();
        BindingSource bindingAntecedentMedicalListe = new BindingSource();
        BindingSource bindingHoraireListe = new BindingSource();

        IEnumerable<TypePrestation> typePrestationListe = new List<TypePrestation>();
        IEnumerable<Medecin> medecinListe = new List<Medecin>();
        IEnumerable<AntecedentMedical> antecedentMedicalListe = new List<AntecedentMedical>();
        IEnumerable<Horaire> horaireListe = new List<Horaire>();

        public void initialise()
        {
            typePrestationListe = Fabrique.getService().listerTypePrestation();
            medecinListe = Fabrique.getService().listerMedecin();
            antecedentMedicalListe= Fabrique.getService().listerAntecedentMedical();
            bindingTypePrestationListeListe.DataSource = typePrestationListe;
            bindingMedecinListe.DataSource = medecinListe;
            bindingAntecedentMedicalListe.DataSource = antecedentMedicalListe;
            bindingHoraireListe.DataSource = horaireListe;

            ajoutRdvView.setListeTypePrestationsBindingSource(bindingTypePrestationListeListe);
            ajoutRdvView.setListeDesMedecinBindingSource(bindingMedecinListe);
            ajoutRdvView.setListeAntecedentMedicalBindingSource(bindingAntecedentMedicalListe);
            ajoutRdvView.setListeHorairesBindingSource(bindingHoraireListe);
            ajoutRdvView.BtnAjouterDemandeRdv.Visible = false;
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
            ajoutRdvView.eventChoixHeureRdv += choisirHeureRdvHandle;
        }

        private void choisirHeureRdvHandle(object sender, EventArgs e)
        {
            Horaire horaire = ajoutRdvView.CboxHeure.SelectedItem as Horaire;
            if (ajoutRdvView.ChboxConsultation.Checked)
            {
                bindingMedecinListe.Clear();
                medecinListe = serviceClinique.listerMedecin(ajoutRdvView.DtpDateRdv, horaire.Id);
                bindingMedecinListe.DataSource = medecinListe;
                ajoutRdvView.BtnAjouterDemandeRdv.Visible = true;
            }
            else
            {
                ajoutRdvView.BtnAjouterDemandeRdv.Visible = true;
            }
        }

        private void rechercheDispoHandle(object sender, EventArgs e)
        {
            if (ajoutRdvView.ChboxConsultation.Checked)
            {
                /*bindingMedecinListe.Clear();
                medecinListe = serviceClinique.listerMedecin(ajoutRdvView.DtpDateRdv,int.Parse(ajoutRdvView.TxtHeure));
                bindingMedecinListe.DataSource = medecinListe;
                if ((medecinListe as List<Medecin>).Count > 0)
                {
                    ajoutRdvView.BtnAjouterDemandeRdv.Visible = true;
                }*/
            }
            else
            {
                /*List<Prestation> prestations = serviceClinique.listerPrestationParHeureEtDate(ajoutRdvView.DtpDateRdv, ajoutRdvView.TxtHeure);
                if(prestations.Count > 0)
                {
                    MessageBox.Show("Plage Occupée");
                }
                else
                {
                    ajoutRdvView.BtnAjouterDemandeRdv.Visible = true;
                }*/
            }
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
                DateNaissance = ajoutRdvView.DtpDateNaissance
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
                Horaire = ajoutRdvView.CboxHeure.SelectedItem as Horaire,
                Medecin = bindingMedecinListe.Current as Medecin
            };
            /*if (ajoutRdvView.ChboxConsultation.Checked)
            {
                rdv.Medecin = bindingMedecinListe.Current as Medecin;
                Consultation consultation = Fabrique.getService().ajouterConsultation(new Consultation() { DateConsultation = ajoutRdvView.DtpDateRdv, EtatConsultation = Etat.EnAttente, Heure = rdv.Heure });
                rdv.Consultation=consultation;
            }
            else
            {
                Prestation prestation =Fabrique.getService().ajouterPrestation(new Prestation() { DatePrestation = ajoutRdvView.DtpDateRdv, EtatPrestation = Etat.EnAttente,Heure=rdv.Heure });
                foreach (var typePrestation in ajoutRdvView.ChlboxListeDesPrestations.CheckedItems)
                {
                    prestation.TypePrestations.Add(typePrestation as TypePrestation);
                }
                Fabrique.getService().ajouterPrestationTypePrestation(prestation);
                rdv.Prestation=prestation;
                rdv.Rp=new Rp() { Id=38,Email="rp@gmail.com",Password="ism123",NomComplet="Responsable des prestations",Disponibilite=Disponibilite.Disponible};
            }*/
            rdv=Fabrique.getService().ajouterRdv(rdv);
            viderInfoPatient();
            ajoutRdvView.BtnAjouterDemandeRdv.Visible = false;
            MessageBox.Show("Rendez-vous créée avec succès.");

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
            ajoutRdvView.BtnAjouterDemandeRdv.Visible = false;
            bool check = ajoutRdvView.ChboxPrestation.Checked;
            ajoutRdvView.ChboxConsultation.Checked = !check;
            ajoutRdvView.LblMedecin.Visible = !check;
            ajoutRdvView.CboxListeDesMedecin.Visible = !check;
        }
        private void choisirConsultationHandle(object sender, EventArgs e)
        {
            ajoutRdvView.BtnAjouterDemandeRdv.Visible = false;
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
            if (ajoutRdvView.ChboxConsultation.Checked)
            {
                horaireListe = serviceClinique.listerHoraire();
                bindingHoraireListe.DataSource = horaireListe;
            }
            else
            {
                horaireListe = serviceClinique.listerHoraireDispoParDate(ajoutRdvView.DtpDateRdv, TypeRdv.Prestation);
                bindingHoraireListe.DataSource = horaireListe;
            }
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
            patientSearch = null;
            for (int i = 0; i < bindingAntecedentMedicalListe.Count; i++)
            {
                ajoutRdvView.ChlboxListeDesAntecedentsMedicaux.SetItemChecked(i, false);
            }
        }

    }
}
