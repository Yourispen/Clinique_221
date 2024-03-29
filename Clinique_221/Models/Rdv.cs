﻿using System;
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
        private DateTime dateRdv;
        private Patient patient;
        private TypeRdv typeRdv;
        private Secretaire secretaire;
        private Medecin medecin;
        private Rp rp;
        private Etat etatRdv;
        private Horaire horaire;

        public Rdv()
        {
            EtatRdv = Etat.EnAttente;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateRdv { get => dateRdv; set => dateRdv = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public TypeRdv TypeRdv { get => typeRdv; set => typeRdv = value; }
        public Secretaire Secretaire { get => secretaire; set => secretaire = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
        public Rp Rp { get => rp; set => rp = value; }
        public Etat EtatRdv { get => etatRdv; set => etatRdv = value; }
        public Horaire Horaire { get => horaire; set => horaire = value; }
    }
}
