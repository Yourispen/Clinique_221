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
        private IRdvRepository rdvRepo;

        public ServiceClinique(IRdvRepository rdvRepo)
        {
            this.rdvRepo = rdvRepo;
        }

        public List<Rdv> listerRdv()
        {
            return rdvRepo.findAll();
        }
    }
}
