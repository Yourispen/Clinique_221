using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models.Dto
{
    public class RdvDto
    {
        private int id;
        private DateTime date;
        private string heure;
        private Patient patient;
        private TypeRdv typeRdv;
        private Medecin medecin;
        private Etat etatRdv;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public TypeRdv TypeRdv { get => typeRdv; set => typeRdv = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
        public Etat EtatRdv { get => etatRdv; set => etatRdv = value; }

        public void toRdvDto(Rdv rdv)
        {
            Date = rdv.DateRdv;
            Patient = rdv.Patient;
            TypeRdv = rdv.TypeRdv;
            Medecin = rdv.Medecin;
            EtatRdv = rdv.EtatRdv;
            id = rdv.Id;
            heure = rdv.Horaire.ToString();
        }
    }
}
