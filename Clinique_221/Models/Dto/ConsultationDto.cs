using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models.Dto
{
    public class ConsultationDto
    {
        private int id;
        private DateTime date;
        private Etat etat;
        private string heure;
        private Patient patient;
        private Medecin medecin;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public string Heure { get => heure; set => heure = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
        public Etat Etat { get => etat; set => etat = value; }

        public void toDto(Consultation consultation)
        {
            Date = consultation.DateConsultation;
            etat = consultation.EtatConsultation;
            id = consultation.Id;
            heure = consultation.Heure;
            patient = consultation.Patient;
            medecin = consultation.Medecin;
        }
    }
}
