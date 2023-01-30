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
    public class UtilisateurRepository : BaseRepository, IUtilisateurRepository
    {
        private readonly string SQL_SELECT_BY_EMAIL = "SELECT * FROM utilisateur where email=@emailUtilisateur";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM utilisateur where id=@idUtilisateur";

        public UtilisateurRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Utilisateur obj)
        {
            throw new NotImplementedException();
        }

        public List<Utilisateur> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Utilisateur> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Utilisateur findById(int id)
        {
            Utilisateur utilisateur = null;
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
                    cmd.Parameters.Add("@idUtilisateur", SqlDbType.Int).Value = id;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    if (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        utilisateur = remplirData(sdr);
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
            return utilisateur;
        }

        public Utilisateur findByLogin(string login)
        {
            Utilisateur utilisateur = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_EMAIL;
                    cmd.Parameters.Add("@emailUtilisateur", SqlDbType.VarChar).Value = login;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        utilisateur = remplirData(sdr);
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

                    connexion.Close();
                }
            }
            return utilisateur;
        }

        public Utilisateur persist(Utilisateur obj)
        {
            throw new NotImplementedException();
        }

        public Utilisateur remplirData(SqlDataReader sdr)
        {
            Utilisateur utilisateur = new Utilisateur()
            {
                Id = (int)sdr[0],
                Email = (string)sdr[1],
                Password = (string)sdr[2],
                NomComplet = (string)sdr[3],
                Role = (Role)Enum.Parse(typeof(Role), sdr[4].ToString()),
            };
            return utilisateur;
        }

        public void update(Utilisateur obj)
        {
            throw new NotImplementedException();
        }
    }
}
