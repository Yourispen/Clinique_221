using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Medicament
    {
        private string code;
        private string nom;

        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
