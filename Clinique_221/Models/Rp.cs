using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Rp : Utilisateur
    {
        private Disponibilite disponibilite;
        private List<Rdv> rdvs = new List<Rdv>();
        public Rp()
        {
            Role = Role.Rp;
        }

        public Disponibilite Disponibilite { get => disponibilite; set => disponibilite = value; }
        public List<Rdv> Rdvs { get => rdvs; set => rdvs = value; }
    }
}
