using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface IConsultationRepository : IRepository<Consultation>
    {
        List<Consultation> findAllByPatient(DateTime date, int idPatient, int idMedecin);
        List<Consultation> findAllByPatient(DateTime date, string codePatient, int idMedecin);
        List<Consultation> findAllByDate(DateTime date, int idMedecin);
        List<Consultation> findAllByEtat(DateTime date, Etat etatConsultation, int idMedecin);
        List<Consultation> findAllByEtat(DateTime date, Etat etatConsultation, string codePatient, int idMedecin);
    }
}
