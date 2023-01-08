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
        private ISpecialiteRepository SpecialiteRepo;

        //Injection de dépendances
        public ServiceClinique(IRdvRepository rdvRepo, IMedecinRepository medecinRepo, ITypePrestationRepository typePrestationRepo, ISpecialiteRepository specialiteRepo)
        {
            this.rdvRepo = rdvRepo;
            this.medecinRepo = medecinRepo;
            this.typePrestationRepo = typePrestationRepo;
            SpecialiteRepo = specialiteRepo;
        }

        public void ajouterRdv(Rdv rdv)
        {
            this.rdvRepo.save(rdv);
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
    }
}
