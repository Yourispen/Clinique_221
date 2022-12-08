using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public enum TypeRdv
    {
        Consultation,Prestation
    }
    public class Rdv
    {
        private int id;
        private SqlDateTime dateRdv;
        private TypeRdv typeRdv;
        private Etat etatRdv;
        private Secretaire secretaire;
        private Patient patient;
        private Medecin medecin;
        private Rp rp;


        public int Id { get => id; set => id = value; }
        public SqlDateTime DateRdv { get => dateRdv; set => dateRdv = value; }
        public TypeRdv TypeRdv { get => typeRdv; set => typeRdv = value; }
        public Etat EtatRdv { get => etatRdv; set => etatRdv = value; }
        public Secretaire Secretaire { get => secretaire; set => secretaire = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
        public Rp Rp { get => rp; set => rp = value; }
    }
}
