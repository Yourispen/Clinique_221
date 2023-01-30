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
        private Patient patient;
        private DateTime dateConsultation;
        private Etat etatConsultation;
        private Ordonnance ordonnance;
        private Medecin medecin;
        List<TypePrestation> typePrestations=new List<TypePrestation>();
        private string heure;

        public Consultation()
        {
            etatConsultation = Etat.EnAttente;
        }

        public Patient Patient { get => patient; set => patient = value; }
        public DateTime DateConsultation { get => dateConsultation; set => dateConsultation = value; }
        public int Id { get => id; set => id = value; }
        public Etat EtatConsultation { get => etatConsultation; set => etatConsultation = value; }
        public Ordonnance Ordonnance { get => ordonnance; set => ordonnance = value; }
        public List<TypePrestation> TypePrestations { get => typePrestations; set => typePrestations = value; }
        public string Heure { get => heure; set => heure = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
    }
}
