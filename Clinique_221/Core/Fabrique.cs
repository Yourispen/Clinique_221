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
        public static IServiceClinique getService()
        {
            IRdvRepository rdvRepo=new RdvRepository();
            return new ServiceClinique(rdvRepo);
        }
    }
}
