using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface IPrestationRepository : IRepository<Prestation>
    {
        void insertPrestationTypePrestation(Prestation prestation,TypePrestation typePrestation);
        List<Prestation> findAllByPatient(int idPatient);
        List<Prestation> findAllByPatient(string codePatient);
        List<Prestation> findAllByDate(string codePatient);
        List<Prestation> findAllByEtat(Etat etatPrestation);
        List<Prestation> findByDateAndHeure(DateTime date, string heure);

    }
}
