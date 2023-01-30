using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models.Dto
{
    public class PatientDto
    {
        private int id;
        private string code;
        private string nomComplet;
        private DateTime dateNaissance;
        private Sexe sexe;

        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public Sexe Sexe { get => sexe; set => sexe = value; }

        public void toPatientDto(Patient patient)
        {
            Code = patient.Code;
            NomComplet = patient.NomComplet;
            DateNaissance = patient.DateNaissance;
            Sexe = patient.Sexe;
            id = patient.Id;
        }

    }
}
