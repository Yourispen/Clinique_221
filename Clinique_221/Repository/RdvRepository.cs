using Clinique_221.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Repository
{
    public class RdvRepository :BaseRepository, IRdvRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM rdv";
        private readonly string SQL_SELECT_ALL_BY_ID_PATIENT = "SELECT * FROM rdv where patient_id=@idPatient";
        private readonly string SQL_SELECT_ALL_BY_CODE_PATIENT = @"SELECT * FROM rdv,utilisateur where utilisateur.code like '%'+@codePatient+'%' and rdv.patient_id=utilisateur.id";
        private readonly string SQL_INSERT = "INSERT INTO rdv(date_rdv,type_rdv,etat,patient_id,medecin_id,rp_id) values(@dateRdv,@typeRdv,@etatRdv,@idPatient,@idMedecin,@idRp)";

        public RdvRepository(string chaineDeConnexion)
        {
            //Data Source = ROLYSPEN; Initial Catalog = CLINIQUE_221; Integrated Security = True
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Rdv obj)
        {
            
        }

        public List<Rdv> findAll()
        {
            List<Rdv> rdvs = new List<Rdv>();

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
                        Rdv rdv = new Rdv()
                        {
                            Id = (int)sdr[0],
                            DateRdv = (DateTime)sdr[1],
                            TypeRdv = (TypeRdv)Enum.Parse(typeof(TypeRdv), sdr[2].ToString()),
                            EtatRdv = (Etat)Enum.Parse(typeof(Etat), sdr[3].ToString())
                            //Patient = (int)sdr[3],
                        };
                        rdvs.Add(rdv);
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

            /*List<Rdv> rdvs = new List<Rdv>();
            {
                new Rdv(){Id=1,Patient=new Patient(){NomComplet="Pat1"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med1"},EtatRdv=Etat.EnCours},
                new Rdv(){Id=2,Patient=new Patient(){NomComplet="Pat2"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med1"},EtatRdv=Etat.EnCours},
                new Rdv(){Id=3,Patient=new Patient(){NomComplet="Pat3"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med2"},EtatRdv=Etat.EnCours},
                new Rdv(){Id=4,Patient=new Patient(){NomComplet="Pat4"},DateRdv= DateTime.Now.Date,TypeRdv=TypeRdv.Consultation,Medecin=new Medecin(){NomComplet="Med2"},EtatRdv=Etat.Annule}
            };*/
            return rdvs;
        }

        public List<Rdv> findAllByDate(DateTime date)
        {
            List<Rdv> rdvs = new List<Rdv>();
            return rdvs;
        }

        public List<Rdv> findAllByEtat(Etat etatRdv)
        {
            throw new NotImplementedException();
        }

        public List<Rdv> findAllByPatient(int idPatient)
        {
            List<Rdv> rdvs = new List<Rdv>();
            //1-Ouvrir la connexion
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    //2-Preparer la requete
                    cmd.CommandText = SQL_SELECT_ALL_BY_ID_PATIENT;
                    //Changer les parametres par leurs valeurs
                    cmd.Parameters.Add("@idPatient",SqlDbType.Int).Value= idPatient;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    while (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        Rdv rdv = new Rdv()
                        {
                            Id = (int)sdr[0],
                            DateRdv = (DateTime)sdr[1],
                            TypeRdv = (TypeRdv)Enum.Parse(typeof(TypeRdv), sdr[2].ToString()),
                            EtatRdv = (Etat)Enum.Parse(typeof(Etat), sdr[3].ToString())
                            //Patient = (int)sdr[3],
                        };
                        rdvs.Add(rdv);
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
            return rdvs;
        }


        public List<Rdv> findAllByPatient(string codePatient)
        {
            List<Rdv> rdvs = new List<Rdv>();
            //1-Ouvrir la connexion
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    //2-Preparer la requete
                    cmd.CommandText = SQL_SELECT_ALL_BY_CODE_PATIENT;
                    //Changer les parametres par leurs valeurs
                    cmd.Parameters.Add("@codePatient", SqlDbType.VarChar).Value = codePatient;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    while (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        Rdv rdv = new Rdv()
                        {
                            Id = (int)sdr[0],
                            DateRdv = (DateTime)sdr[1],
                            TypeRdv = (TypeRdv)Enum.Parse(typeof(TypeRdv), sdr[2].ToString()),
                            EtatRdv = (Etat)Enum.Parse(typeof(Etat), sdr[3].ToString())
                            //Patient = (int)sdr[3],
                        };
                        rdvs.Add(rdv);
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
            return rdvs;
        }

        public List<Rdv> findAllByPatientAndDate(String codePatient, DateTime date)
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
            //1-Ouvrir la connexion
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    //2-Preparer la requete
                    cmd.CommandText = SQL_INSERT;
                    //Changer les parametres par leurs valeurs
                    cmd.Parameters.Add("@dateRdv", SqlDbType.Date).Value = obj.DateRdv;
                    cmd.Parameters.Add("@typeRdv", SqlDbType.VarChar).Value = obj.TypeRdv.ToString();
                    cmd.Parameters.Add("@etatRdv", SqlDbType.VarChar).Value = obj.EtatRdv.ToString();
                    cmd.Parameters.Add("@idPatient", SqlDbType.VarChar).Value = obj.Patient.Id;
                    cmd.Parameters.Add("@idMedecin", SqlDbType.VarChar).Value = obj.Medecin.Id;
                    cmd.Parameters.Add("@idRp", SqlDbType.VarChar).Value = obj.Rp.Id;
                    //3-Executer la requete et recuperer les données
                    cmd.ExecuteNonQuery();
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
        }

        public void update(Rdv obj)
        {
            
        }
       
    }
}
