using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Prestation
    {
        private int id;
        private Rdv rdv;
        private DateTime datePrestation;
        private Etat etatPrestation;

        public Prestation()
        {
            etatPrestation = Etat.EnCours;
        }

        public Rdv Rdv { get => rdv; set => rdv = value; }
        public DateTime DatePrestation { get => datePrestation; set => datePrestation = value; }
        public Etat EtatPrestation { get => etatPrestation; set => etatPrestation = value; }
        public int Id { get => id; set => id = value; }
    }
}
