using Clinique_221.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class MedecinRepository : BaseRepository, IMedecinRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM utilisateur where role='Medecin'";
        ISpecialiteRepository specialiteRepository;
        public MedecinRepository(string chaineDeConnexion,ISpecialiteRepository specialiteRepository)
        {
            this.specialiteRepository = specialiteRepository;
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Medecin obj)
        {
            throw new NotImplementedException();
        }

        public List<Medecin> findAll()
        {
            List<Medecin> medecins = new List<Medecin>();

            //1-Ouvrir la connexion
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    //2-Preparer la requete
                    cmd.CommandText = SQL_SELECT_ALL;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    while (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        Medecin medecin = new Medecin()
                        {
                            Id = (int)sdr[0],
                            Email = (string)sdr[1],
                            Password = (string)sdr[2],
                            NomComplet = (string)sdr[3],
                            Role = (Role)Enum.Parse(typeof(Role), sdr[4].ToString()),
                            Sexe = (Sexe)Enum.Parse(typeof(Sexe), sdr[5].ToString()),
                            TypeMedecin = (TypeMedecin)Enum.Parse(typeof(TypeMedecin), sdr[6].ToString()),
                            Disponibilite = (Disponibilite)Enum.Parse(typeof(Disponibilite), sdr[8].ToString()),
                        };
                        //medecin.Specialite= medecin.TypeMedecin==TypeMedecin.Specialiste?null:specialiteRepository.findById((int)sdr[7]);
                        medecins.Add(medecin);
                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    cmd.Dispose();

                    //5-Fermeture de la connexion
                    connexion.Close();
                }
            }
            return medecins;
        }

        public List<Medecin> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Medecin findById(int id)
        {
            throw new NotImplementedException();
        }

        public void save(Medecin obj)
        {
            throw new NotImplementedException();
        }

        public void update(Medecin obj)
        {
            throw new NotImplementedException();
        }
    }
}
