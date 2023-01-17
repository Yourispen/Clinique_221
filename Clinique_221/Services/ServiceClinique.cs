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
        IConstanteRepository constanteRepo;
        private IOrdonnanceRepository ordonnanceRepo;
        IConsultationRepository consultationRepo;

        //Injection de dépendances
        public ServiceClinique(IRdvRepository rdvRepo, IMedecinRepository medecinRepo, ITypePrestationRepository typePrestationRepo, ISpecialiteRepository specialiteRepo, IPatientRepository patientRepo, IAntecedentMedicalRepository antecedentMedicalRepo, IMedicamentRepository medicamentRepo, IOrdonnanceMedicamentRepository ordonnanceMedicamentRepo, IConstanteRepository constanteRepo, IOrdonnanceRepository ordonnanceRepo, IConsultationRepository consultationRepo)
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
        }

        public AntecedentMedical ajouterAntecedentMedical(AntecedentMedical antecedentMedical)
        {
            return antecedentMedicalRepo.persist(antecedentMedical);
        }

        public void ajouterAntecedentMedicalUnPatient(Patient patient, List<AntecedentMedical> antecedentMedicaux)
        {
           antecedentMedicalRepo.persistByPatient(patient,antecedentMedicaux);
        }

        public Patient ajouterPatient(Patient patient)
        {
            return patientRepo.persist(patient);
        }

        public Rdv ajouterRdv(Rdv rdv)
        {
            return rdvRepo.persist(rdv);
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
    }
}
