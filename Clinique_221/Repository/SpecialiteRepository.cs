using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class SpecialiteRepository : BaseRepository, ISpecialiteRepository
    {
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM specialite where id=@idSpecialite";

        public SpecialiteRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Specialite obj)
        {
            throw new NotImplementedException();
        }

        public List<Specialite> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Specialite> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Specialite findById(int id)
        {
            Specialite specialite=null;
            //1-Ouvrir la connexion
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    //2-Preparer la requete
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    //Changer les parametres par leurs valeurs
                    cmd.Parameters.Add("@idSpecialite", SqlDbType.Int).Value = id;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    if (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        specialite = new Specialite()
                        {
                            Id = (int)sdr[0],
                            Libelle = (string)sdr[1],
                        };
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
            return specialite;
        }

        public void save(Specialite obj)
        {
            throw new NotImplementedException();
        }

        public void update(Specialite obj)
        {
            throw new NotImplementedException();
        }
    }
}
