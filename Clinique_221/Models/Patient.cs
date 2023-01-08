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
        private string nomParent;
        private TypePatient typePatient;
        private List<AntecedantMedical> antecedantMedicaux=new List<AntecedantMedical>();
        private List<Rdv> rdvs=new List<Rdv>();


        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Code { get => code; set => code = value; }
        public string NomParent { get => nomParent; set => nomParent = value; }
        public List<AntecedantMedical> AntecedantMedicaux { get => antecedantMedicaux; set => antecedantMedicaux = value; }
        public List<Rdv> Rdvs { get => rdvs; set => rdvs = value; }
        public TypePatient TypePatient { get => typePatient; set => typePatient = value; }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
