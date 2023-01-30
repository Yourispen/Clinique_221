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
        private DateTime datePrestation;
        private Etat etatPrestation;
        private Patient patient;
        List<TypePrestation> typePrestations=new List<TypePrestation>();
        private string heure;

        public Prestation()
        {
            etatPrestation = Etat.EnAttente;
        }

        public DateTime DatePrestation { get => datePrestation; set => datePrestation = value; }
        public Etat EtatPrestation { get => etatPrestation; set => etatPrestation = value; }
        public int Id { get => id; set => id = value; }
        public List<TypePrestation> TypePrestations { get => typePrestations; set => typePrestations = value; }
        public string Heure { get => heure; set => heure = value; }
        public Patient Patient { get => patient; set => patient = value; }
    }
}
