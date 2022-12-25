using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public enum TypeMedecin
    {
        Specialiste,Generaliste
    }
    public class Medecin:Utilisateur
    {
        private TypeMedecin typeMedecin;
        private Specialite specialite;
        private Disponibilite disponibilite;
        private List<Rdv> rdvs = new List<Rdv>();
        private List<Consultation> consultations = new List<Consultation>();

        public TypeMedecin TypeMedecin { get => typeMedecin; set => typeMedecin = value; }
        public Specialite Specialite { get => specialite; set => specialite = value; }
        public Disponibilite Disponibilite { get => disponibilite; set => disponibilite = value; }
        public List<Rdv> Rdvs { get => rdvs; set => rdvs = value; }
        public List<Consultation> Consultations { get => consultations; set => consultations = value; }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
