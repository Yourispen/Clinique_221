using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class TypePrestationRepository : BaseRepository, ITypePrestationRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM type_prestation";

        public TypePrestationRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(TypePrestation obj)
        {
            throw new NotImplementedException();
        }

        public List<TypePrestation> findAll()
        {
            List<TypePrestation> typePrestations = new List<TypePrestation>();

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
                        TypePrestation typePrestation = new TypePrestation()
                        {
                            Id = (int)sdr[0],
                            Libelle = (string)sdr[1],
                        };
                        typePrestations.Add(typePrestation);
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
            return typePrestations;
        }

        public List<TypePrestation> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public TypePrestation findById(int id)
        {
            throw new NotImplementedException();
        }

        public TypePrestation persist(TypePrestation obj)
        {
            throw new NotImplementedException();
        }

        public TypePrestation remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(TypePrestation obj)
        {
            throw new NotImplementedException();
        }
    }
}
