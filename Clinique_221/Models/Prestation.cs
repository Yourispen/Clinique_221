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
        List<TypePrestation> typePrestations=new List<TypePrestation>();

        public Prestation()
        {
            etatPrestation = Etat.EnAttente;
        }

        public Rdv Rdv { get => rdv; set => rdv = value; }
        public DateTime DatePrestation { get => datePrestation; set => datePrestation = value; }
        public Etat EtatPrestation { get => etatPrestation; set => etatPrestation = value; }
        public int Id { get => id; set => id = value; }
        public List<TypePrestation> TypePrestations { get => typePrestations; set => typePrestations = value; }
    }
}
