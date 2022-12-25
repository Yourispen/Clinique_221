using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class RdvRepository :BaseRepository, IRdvRepository
    {
        public void delete(Rdv obj)
        {
            
        }

        public List<Rdv> findAll()
        {
            List<Rdv> rdvs = new List<Rdv>()
            {
                new Rdv(){Id=1,Patient=new Patient(){NomComplet="Pat1"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med1"},EtatRdv=Etat.EnCours},
                new Rdv(){Id=2,Patient=new Patient(){NomComplet="Pat2"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med1"},EtatRdv=Etat.EnCours},
                new Rdv(){Id=3,Patient=new Patient(){NomComplet="Pat3"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med2"},EtatRdv=Etat.EnCours},
                new Rdv(){Id=4,Patient=new Patient(){NomComplet="Pat4"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med2"},EtatRdv=Etat.Annule}
            };
            return rdvs;
        }

        public List<Rdv> findAllByDate(DateTime date)
        {
            List<Rdv> rdvs = new List<Rdv>();
            return rdvs;
        }

        public Rdv findById(int id)
        {
            return null;
        }

        public void save(Rdv obj)
        {
            
        }

        public void update(Rdv obj)
        {
            
        }
        List<Rdv> findAllByPatient(Patient patient) 
        {
            List<Rdv> rdvs = new List<Rdv>();
            return rdvs;
        }
        List<Rdv> findAllByPatientAndDate(Patient patient,DateTime date)
        {
            List<Rdv> rdvs = new List<Rdv>();
            return rdvs;
        }
    }
}
