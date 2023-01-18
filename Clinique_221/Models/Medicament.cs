using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Medicament
    {
        private int id;
        private string code;
        private string nom;
        private List<OrdonnanceMedicament> ordonnanceMedicaments = new List<OrdonnanceMedicament>();

        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Id { get => id; set => id = value; }
        public List<OrdonnanceMedicament> OrdonnanceMedicaments { get => ordonnanceMedicaments; set => ordonnanceMedicaments = value; }

        public override string ToString()
        {
            return nom;
        }
    }
}
