using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models.Dto
{
    public class PrestationDto
    {
        private int id;
        private DateTime date;
        private Etat etat;
        private string heure;
        private Patient patient;

        public int Id { get => id; set => id = value; }
        public Patient Patient { get => patient; set => patient = value; }

        public DateTime Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public Etat Etat { get => etat; set => etat = value; }

        public void toDto(Prestation prestation)
        {
            Date = prestation.DatePrestation;
            etat = prestation.EtatPrestation;
            id = prestation.Id;
            heure = prestation.Heure;
            patient = prestation.Patient;
        }
    }
}
