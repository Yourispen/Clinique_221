using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Services
{
    public interface IServiceClinique
    {
        List<Rdv> listerRdv();
        List<Rdv> listerRdv(DateTime date);
        Rdv ajouterRdv(Rdv rdv);
        List<Rdv> listerRdvParPatient(int idPatient);
        List<Rdv> listerRdvParMedecin(int idMedecin, DateTime date);
        List<Rdv> listerRdvParRp(int idRp, DateTime date);
        List<Rdv> listerRdvParPatient(string codePatient);
        Rdv rechercherRdv(int id);
        List<TypePrestation> listerTypePrestation();
        List<TypePrestation> listerTypePrestation(string codePatient);
        List<TypePrestation> listerTypePrestation(Prestation prestation);
        List<Medecin> listerMedecin();
        List<Medecin> listerMedecin(DateTime date);
        List<Medecin> listerMedecin(DateTime date,int idHoraire);
        Medecin rechercherMedecin(int id);
        Patient rechercherPatient(string code);
        Patient rechercherPatient(int id);
        Patient ajouterPatient(Patient patient);
        List<AntecedentMedical> listerAntecedentMedical();
        List<AntecedentMedical> listerAntecedentMedical(int idPatient);
        AntecedentMedical ajouterAntecedentMedical(AntecedentMedical antecedentMedical);
        void ajouterAntecedentMedicalUnPatient(Patient patient,List<AntecedentMedical> antecedentMedicaux);
        Consultation ajouterConsultation(Consultation consultation);
        Prestation ajouterPrestation(Prestation prestation);
        void ajouterPrestationTypePrestation(Prestation prestation);
        List<Patient> listerPatient();
        List<Consultation> listerConsultation();
        List<Consultation> listerConsultation(DateTime date);
        List<Consultation> listerConsultation(DateTime date,Etat etat,int idMedecin);
        List<Consultation> listerConsultation(DateTime date, Etat etat, string codePatient, int idMedecin);
        List<Consultation> listerConsultation(DateTime date,int idMedecin);
        List<Consultation> listerConsultation(DateTime date,string codePatient, int idMedecin);
        List<Consultation> listerConsultation(int idPatient, int idMedecin);
        Consultation rechercherConsultation(int id);
        List<Prestation> listerPrestation();
        List<Prestation> listerPrestation(DateTime date);
        List<Prestation> listerPrestation(DateTime date,Etat etat);
        List<Prestation> listerPrestation(DateTime date, Etat etat, string codePatient);
        List<Prestation> listerPrestation(DateTime date, string codePatient);
        List<Prestation> listerPrestation(DateTime date, int idPatient);
        List<Prestation> listerPrestationParHeureEtDate(DateTime date, string heure);
        List<Horaire> listerHoraireDispoParDate(DateTime date, TypeRdv typeRdv);
        List<Horaire> listerHoraire();
        Prestation rechercherPrestation(int id);
        Utilisateur seConnecter(string login);
        List<Medicament> listerMedicament();
        List<Medicament> listerMedicament(Ordonnance ordonnance);
        Medicament rechercherMedicament(string code);
        Ordonnance ajouterOrdonnance(Ordonnance ordonnance);
        void ajouterOrdonnanceMedicaments(int idOrdonnance, List<Medicament> medicaments);

    }
}
