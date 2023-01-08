using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface IRdvRepository:IRepository<Rdv>
    {
        List<Rdv> findAllByPatient(int idPatient);
        List<Rdv> findAllByEtat(Etat etatRdv);
        List<Rdv> findAllByPatient(string codePatient);
        List<Rdv> findAllByPatientAndDate(String codePatient, DateTime date);
    }
}
