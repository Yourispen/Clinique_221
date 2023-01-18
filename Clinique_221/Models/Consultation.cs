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
        List<TypePrestation> typePrestations=new List<TypePrestation>();

        public Consultation()
        {
            etatConsultation = Etat.EnAttente;
        }

        public Rdv Rdv { get => rdv; set => rdv = value; }
        public DateTime DateConsultation { get => dateConsultation; set => dateConsultation = value; }
        public int Id { get => id; set => id = value; }
        public Etat EtatConsultation { get => etatConsultation; set => etatConsultation = value; }
        public Ordonnance Ordonnance { get => ordonnance; set => ordonnance = value; }
        public List<TypePrestation> TypePrestations { get => typePrestations; set => typePrestations = value; }
    }
}
