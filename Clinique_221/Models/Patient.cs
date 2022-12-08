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
        Enfant,Adulte
    }
    public class Patient : User
    {
        private SqlDateTime dateNaissance;
        private string tel;
        private string nomParent;
        private TypePatient typePatient;
        private List<AntecedantMedical> antecedantMedicaux=new List<AntecedantMedical>();
        private List<Rdv> rdvs=new List<Rdv>();


        public SqlDateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Tel { get => tel; set => tel = value; }
        public string NomParent { get => nomParent; set => nomParent = value; }
        public List<AntecedantMedical> AntecedantMedicaux { get => antecedantMedicaux; set => antecedantMedicaux = value; }
        public List<Rdv> Rdvs { get => rdvs; set => rdvs = value; }
        public TypePatient TypePatient { get => typePatient; set => typePatient = value; }
    }
}
