using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public enum TypePatient
    {
        Adulte,Enfant
    }
    public class Patient : Utilisateur
    {
        private DateTime dateNaissance;
        private string code;
        private List<AntecedentMedical> antecedentMedicaux=new List<AntecedentMedical>();
        private List<Rdv> rdvs=new List<Rdv>();

        public Patient()
        {
            Role = Role.Patient;
        }

        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Code { get => code; set => code = value; }
        public List<AntecedentMedical> AntecedantMedicaux { get => antecedentMedicaux; set => antecedentMedicaux = value; }
        public List<Rdv> Rdvs { get => rdvs; set => rdvs = value; }

        
    }
}
