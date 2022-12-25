using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models.Dto
{
    public class RdvDto
    {
        private DateTime dateRdv;
        private Patient patient;
        private TypeRdv typeRdv;
        private Medecin medecin;
        private Etat etatRdv;
        public void toRdvDto(Rdv rdv)
        {
            dateRdv = rdv.DateRdv;
            patient = rdv.Patient;
            typeRdv = rdv.TypeRdv;
            medecin = rdv.Medecin;
            etatRdv = rdv.EtatRdv;
        }
    }
}
