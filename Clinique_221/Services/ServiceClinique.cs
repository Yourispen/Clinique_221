using Clinique_221.Models;
using Clinique_221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Services
{
    public class ServiceClinique : IServiceClinique
    {
        //Couplage faible
        private IRdvRepository rdvRepo;
        private IMedecinRepository medecinRepo;
        private ITypePrestationRepository typePrestationRepo;
        private ISpecialiteRepository specialiteRepo;
        private IPatientRepository patientRepo;
        private IAntecedentMedicalRepository antecedentMedicalRepo;
        private IMedicamentRepository medicamentRepo;
        private IOrdonnanceMedicamentRepository ordonnanceMedicamentRepo;
        private IConstanteRepository constanteRepo;
        private IOrdonnanceRepository ordonnanceRepo;
        private IConsultationRepository consultationRepo;
        private IPrestationRepository prestationRepo;
        private IUtilisateurRepository utilisateurRepo;
        private IHoraireRepository horaireRepo;

        //Injection de dépendances
        public ServiceClinique(IRdvRepository rdvRepo, IMedecinRepository medecinRepo, ITypePrestationRepository typePrestationRepo, ISpecialiteRepository specialiteRepo, IPatientRepository patientRepo, IAntecedentMedicalRepository antecedentMedicalRepo, IMedicamentRepository medicamentRepo, IOrdonnanceMedicamentRepository ordonnanceMedicamentRepo, IConstanteRepository constanteRepo, IOrdonnanceRepository ordonnanceRepo, IConsultationRepository consultationRepo, IPrestationRepository prestationRepo, IUtilisateurRepository utilisateurRepo,IHoraireRepository horaireRepo)
        {
            this.rdvRepo = rdvRepo;
            this.medecinRepo = medecinRepo;
            this.typePrestationRepo = typePrestationRepo;
            this.specialiteRepo = specialiteRepo;
            this.patientRepo = patientRepo;
            this.antecedentMedicalRepo = antecedentMedicalRepo;
            this.medicamentRepo = medicamentRepo;
            this.ordonnanceMedicamentRepo = ordonnanceMedicamentRepo;
            this.constanteRepo = constanteRepo;
            this.ordonnanceRepo = ordonnanceRepo;
            this.consultationRepo = consultationRepo;
            this.prestationRepo = prestationRepo;
            this.utilisateurRepo = utilisateurRepo;
            this.horaireRepo = horaireRepo;
        }

        public AntecedentMedical ajouterAntecedentMedical(AntecedentMedical antecedentMedical)
        {
            return antecedentMedicalRepo.persist(antecedentMedical);
        }

        public void ajouterAntecedentMedicalUnPatient(Patient patient, List<AntecedentMedical> antecedentMedicaux)
        {
           antecedentMedicalRepo.persistByPatient(patient,antecedentMedicaux);
        }

        public Consultation ajouterConsultation(Consultation consultation)
        {
            return consultationRepo.persist(consultation);
        }

        public Patient ajouterPatient(Patient patient)
        {
            return patientRepo.persist(patient);
        }

        public Prestation ajouterPrestation(Prestation prestation)
        {
            return prestationRepo.persist(prestation);
        }

        public void ajouterPrestationTypePrestation(Prestation prestation)
        {
            foreach (var typePrestation in prestation.TypePrestations)
            {
                prestationRepo.insertPrestationTypePrestation(prestation, typePrestation);
            }
        }

        public Rdv ajouterRdv(Rdv rdv)
        {
            return rdvRepo.persist(rdv);
        }

        public List<Patient> listerPatient()
        {
            return patientRepo.findAll();
        }

        public List<AntecedentMedical> listerAntecedentMedical()
        {
            return antecedentMedicalRepo.findAll();
        }

        public List<AntecedentMedical> listerAntecedentMedical(int idPatient)
        {
            return antecedentMedicalRepo.findAllByPatient(idPatient);
        }

        public List<Medecin> listerMedecin()
        {
            return medecinRepo.findAll();
        }

        public List<Medecin> listerMedecin(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Rdv> listerRdv()
        {
            return rdvRepo.findAll();
        }

        public List<Rdv> listerRdvParPatient(int idPatient)
        {
            return rdvRepo.findAllByPatient(idPatient);
        }

        public List<Rdv> listerRdvParPatient(string codePatient)
        {
            return rdvRepo.findAllByPatient(codePatient);
        }

        public List<TypePrestation> listerTypePrestation()
        {
            return typePrestationRepo.findAll();
        }

        public List<TypePrestation> listerTypePrestation(string codePatient)
        {
            throw new NotImplementedException();
        }

        public Patient rechercherPatient(string code)
        {
            return patientRepo.findByCode(code);
        }

        public List<Rdv> listerRdv(DateTime date)
        {
            return rdvRepo.findAllByDate(date);
        }

        public Rdv rechercherRdv(int id)
        {
            return rdvRepo.findById(id);
        }

        public Patient rechercherPatient(int id)
        {
            return patientRepo.findById(id);
        }

        public List<Consultation> listerConsultation()
        {
            throw new NotImplementedException();
        }

        public List<Consultation> listerConsultation(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> listerConsultation(DateTime date, string codePatient, int idMedecin)
        {
            return consultationRepo.findAllByPatient(date,codePatient,idMedecin);
        }

        public List<Consultation> listerConsultation(DateTime date, Etat etat, int idMedecin)
        {
            return consultationRepo.findAllByEtat(date,etat,idMedecin);
        }

        public List<Prestation> listerPrestation()
        {
            throw new NotImplementedException();
        }

        public List<Prestation> listerPrestation(DateTime date)
        {
            return prestationRepo.findAllByDate(date);
        }

        public List<Prestation> listerPrestation(DateTime date, string codePatient)
        {
            return prestationRepo.findAllByPatient(codePatient);
        }

        public List<Prestation> listerPrestation(DateTime date, int idPatient)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> listerConsultation(DateTime date, int idMedecin)
        {
            return consultationRepo.findAllByDate(date, idMedecin);
        }

        public Prestation rechercherPrestation(int id)
        {
            return prestationRepo.findById(id);
        }

        public Consultation rechercherConsultation(int id)
        {
            return consultationRepo.findById(id);
        }

        public Medecin rechercherMedecin(int id)
        {
            return medecinRepo.findById(id);
        }

        public List<Consultation> listerConsultation(DateTime date, Etat etat, string codePatient, int idMedecin)
        {
            return consultationRepo.findAllByEtat(date,etat,codePatient,idMedecin);
        }

        public List<Consultation> listerConsultation(int idPatient, int idMedecin)
        {
            throw new NotImplementedException();
        }

        public List<Prestation> listerPrestation(DateTime date, Etat etat)
        {
            throw new NotImplementedException();
        }

        public List<Prestation> listerPrestation(DateTime date, Etat etat, string codePatient)
        {
            throw new NotImplementedException();
        }

        public Utilisateur seConnecter(string login)
        {
            return utilisateurRepo.findByLogin(login) ;
        }

        public List<Medecin> listerMedecin(DateTime date, int idHoraire)
        {
            return medecinRepo.findByDateAndHeure(date, idHoraire);
        }

        public List<Prestation> listerPrestationParHeureEtDate(DateTime date, string heure)
        {
            return prestationRepo.findByDateAndHeure(date, heure);
        }

        public List<Horaire> listerHoraireDispoParDate(DateTime date, TypeRdv typeRdv)
        {
            return horaireRepo.findAllDispoByDate(date, typeRdv);
        }

        public List<Horaire> listerHoraire()
        {
           return horaireRepo.findAll();
        }

        public List<TypePrestation> listerTypePrestation(Prestation prestation)
        {
            return typePrestationRepo.findAllByPrestation(prestation);
        }

        public List<Medicament> listerMedicament()
        {
            return medicamentRepo.findAll();
        }
        public Medicament rechercherMedicament(string code)
        {
            return medicamentRepo.findByCode(code);
        }
        public void ajouterOrdonnanceMedicaments(int idOrdonnance,List<Medicament> medicaments)
        {
            OrdonnanceMedicament ordonnanceMedicament;
            foreach (var medicament in medicaments)
            {
                ordonnanceMedicament = new OrdonnanceMedicament()
                {
                    Medicament = medicament,
                    Ordonnance = new Ordonnance() { Id = idOrdonnance }
                };
                ordonnanceMedicamentRepo.persist(ordonnanceMedicament);
            }
        }

        public Ordonnance ajouterOrdonnance(Ordonnance ordonnance)
        {
            return ordonnanceRepo.persist(ordonnance);
        }

        public List<Medicament> listerMedicament(Ordonnance ordonnance)
        {
            return medicamentRepo.findByOrdonnance(ordonnance);
        }

        public List<Rdv> listerRdvParMedecin(int idMedecin, DateTime date)
        {
            return rdvRepo.findAllByMedecin(idMedecin, date);
        }

        public List<Rdv> listerRdvParRp(int idRp, DateTime date)
        {
            return rdvRepo.findAllByRp(idRp, date);
        }
    }
}
