using Clinique_221.Repository;
using Clinique_221.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Core
{
    public class Fabrique
    {
        private static ServiceClinique serviceClinique;
        //centralisation de la création d'objets
        public static IServiceClinique getService()
        {
            if (serviceClinique == null)
            {
                string chaineDeConnexion = "Data Source = ROLYSPEN; Initial Catalog = CLINIQUE_221; Integrated Security = True";
                ISpecialiteRepository specialiteRepo = new SpecialiteRepository(chaineDeConnexion);
                IMedecinRepository medecinRepo = new MedecinRepository(chaineDeConnexion,specialiteRepo);
                ITypePrestationRepository typePrestationRepo = new TypePrestationRepository(chaineDeConnexion);
                IRdvRepository rdvRepo = new RdvRepository(chaineDeConnexion);
                serviceClinique = new ServiceClinique(rdvRepo,medecinRepo,typePrestationRepo,specialiteRepo);
            }
            return serviceClinique;
        }
    }
}
