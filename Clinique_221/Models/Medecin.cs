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

        public Medecin()
        {
            Role = Role.Medecin;
        }

        public TypeMedecin TypeMedecin { get => typeMedecin; set => typeMedecin = value; }
        public Specialite Specialite { get => specialite; set => specialite = value; }
        public Disponibilite Disponibilite { get => disponibilite; set => disponibilite = value; }
        public List<Rdv> Rdvs { get => rdvs; set => rdvs = value; }

    }
}
