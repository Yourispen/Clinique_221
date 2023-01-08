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
        List<Rdv> listerRdvParPatient(int idPatient);
        List<Rdv> listerRdvParPatient(string codePatient);
        List<TypePrestation> listerTypePrestation();
        List<TypePrestation> listerTypePrestation(string codePatient);
        List<Medecin> listerMedecin();
        List<Medecin> listerMedecin(DateTime date);
        void ajouterRdv(Rdv rdv);
    }
}
