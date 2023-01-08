using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class TypePrestation
    {
        private int id;
        private string libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
