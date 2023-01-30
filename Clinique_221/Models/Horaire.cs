using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Horaire
    {
        private int id;
        private string heure;

        public int Id { get => id; set => id = value; }
        public string Heure { get => heure; set => heure = value; }

        public override string ToString()
        {
            return heure;
        }
    }
}
