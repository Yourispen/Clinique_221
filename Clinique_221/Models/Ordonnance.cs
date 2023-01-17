using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Ordonnance
    {
        private int id;
        private DateTime dateOrdonnance;
        private Consultation consultation;
        private List<Constante> constantes=new List<Constante>();
        private List<OrdonnanceMedicament> ordonnanceMedicament = new List<OrdonnanceMedicament>();

        public int Id { get => id; set => id = value; }
        public List<Constante> Constantes { get => constantes; set => constantes = value; }
        public DateTime DateOrdonnance { get => dateOrdonnance; set => dateOrdonnance = value; }
        public List<OrdonnanceMedicament> OrdonnanceMedicament { get => ordonnanceMedicament; set => ordonnanceMedicament = value; }
        public Consultation Consultation { get => consultation; set => consultation = value; }
    }
}
