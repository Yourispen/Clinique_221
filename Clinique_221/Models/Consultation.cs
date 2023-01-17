using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Consultation
    {
        private int id;
        private Rdv rdv;
        private DateTime dateConsultation;
        private Etat etatConsultation;
        private Ordonnance ordonnance;

        public Consultation()
        {
            etatConsultation = Etat.EnCours;
        }

        public Rdv Rdv { get => rdv; set => rdv = value; }
        public DateTime DateConsultation { get => dateConsultation; set => dateConsultation = value; }
        public int Id { get => id; set => id = value; }
        public Etat EtatConsultation { get => etatConsultation; set => etatConsultation = value; }
        public Ordonnance Ordonnance { get => ordonnance; set => ordonnance = value; }
    }
}
