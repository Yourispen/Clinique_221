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
        private readonly string SQL_SELECT_ALL = @"SELECT * FROM rdv";
        private readonly string SQL_SELECT_ALL_BY_DATE = @"SELECT * FROM rdv WHERE date_rdv=@dateJour ORDER BY date_rdv DESC";
        private readonly string SQL_SELECT_ALL_BY_ID_PATIENT = @"SELECT * FROM rdv where patient_id=@idPatient ORDER BY date_rdv DESC";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM rdv where id=@idRdv";
        private readonly string SQL_SELECT_ALL_BY_MEDECIN_AND_DATE = @"SELECT * FROM rdv where medecin_id=@idMedecin and date_rdv=@date  ORDER BY date_rdv DESC";
        private readonly string SQL_SELECT_ALL_BY_RP_AND_DATE = @"SELECT * FROM rdv where rp_id=@idRp and date_rdv=@date  ORDER BY date_rdv DESC";
        private readonly string SQL_SELECT_ALL_BY_CODE_PATIENT = @"SELECT * FROM rdv,utilisateur where utilisateur.code like '%'+@codePatient+'%' and rdv.patient_id=utilisateur.id ORDER BY date_rdv DESC";
        private readonly string SQL_INSERT = @"INSERT INTO rdv(date_rdv,type_rdv,etat,medecin_id,rp_id,patient_id,horaire_id) values(@dateRdv,@typeRdv,@etatRdv,@idMedecin,@idRp,@idPatient,@idHoraire); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_UPDATE = @"UPDATE rdv SET date_rdv=@dateRdv, type_rdv=@typeRdv, etat=@etatRdv, patient_id=@idPatient, medecin_id=@idMedecin,horaire_id=@idHoraire WHERE id=@idRdv";

        IMedecinRepository medecinRepo;
        IConsultationRepository consultationRepo;
        IPrestationRepository prestationRepo;
        IPatientRepository patientRepo;
        IHoraireRepository horaireRepo;
        IUtilisateurRepository utilisateurRepo;
        public RdvRepository(string chaineDeConnexion, IMedecinRepository medecinRepo, IConsultationRepository consultationRepo, IPrestationRepository prestationRepo, IPatientRepository patientRepo, IHoraireRepository horaireRepo,IUtilisateurRepository utilisateurRepo)
        {
            //Data Source = ROLYSPEN; Initial Catalog = CLINIQUE_221; Integrated Security = True
            ChaineDeConnexion = chaineDeConnexion;
            this.medecinRepo = medecinRepo;
            this.consultationRepo = consultationRepo;
            this.prestationRepo = prestationRepo;
            this.patientRepo = patientRepo;
            this.horaireRepo = horaireRepo;
            this.utilisateurRepo = utilisateurRepo;
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
                        Rdv rdv = remplirData(sdr);
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

        public List<Rdv> findAllByDate(DateTime date)
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
                    cmd.CommandText = SQL_SELECT_ALL_BY_DATE;
                    cmd.Parameters.Add("@dateJour", SqlDbType.Date).Value = date;

                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    while (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        Rdv rdv = remplirData(sdr);
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

        public List<Rdv> findAllByEtat(Etat etatRdv)
        {
            throw new NotImplementedException();
        }

        public List<Rdv> findAllByMedecin(int idMedecin,DateTime date)
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
                    cmd.CommandText = SQL_SELECT_ALL_BY_MEDECIN_AND_DATE;
                    //Changer les parametres par leurs valeurs
                    cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = idMedecin;
                    cmd.Parameters.Add("@date", SqlDbType.Int).Value = date;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    while (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        Rdv rdv = remplirData(sdr);
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
                        Rdv rdv = remplirData(sdr);
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
                        Rdv rdv = remplirData(sdr);
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

        public List<Rdv> findAllByRp(int idRp, DateTime date)
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
                    cmd.CommandText = SQL_SELECT_ALL_BY_RP_AND_DATE;
                    //Changer les parametres par leurs valeurs
                    cmd.Parameters.Add("@idRp", SqlDbType.Int).Value = idRp;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    while (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        Rdv rdv = remplirData(sdr);
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

        public Rdv findById(int id)
        {
            Rdv rdv = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idRdv", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        rdv = remplirData(sdr);
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
            return rdv;
        }

        public Rdv persist(Rdv obj)
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
                    if (obj.Id != 0)
                    {
                        cmd.CommandText = SQL_UPDATE;
                        cmd.Parameters.Add("@idRdv", SqlDbType.Int).Value = obj.Id;
                    }
                    else
                    {
                        cmd.CommandText = SQL_INSERT;
                    }
                    
                    //Changer les parametres par leurs valeurs
                    cmd.Parameters.Add("@dateRdv", SqlDbType.Date).Value = obj.DateRdv;
                    cmd.Parameters.Add("@typeRdv", SqlDbType.VarChar).Value = obj.TypeRdv.ToString();
                    cmd.Parameters.Add("@etatRdv", SqlDbType.VarChar).Value = obj.EtatRdv.ToString();
                    cmd.Parameters.Add("@idHoraire", SqlDbType.Int).Value = obj.Horaire.Id;
                    if (obj.TypeRdv==TypeRdv.Consultation)
                    {
                        cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = obj.Medecin.Id;
                        cmd.Parameters.Add("@idRp", SqlDbType.Int).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = DBNull.Value;
                        int idRp = 38;
                        cmd.Parameters.Add("@idRp", SqlDbType.Int).Value = idRp;
                    }
                    cmd.Parameters.Add("@idPatient", SqlDbType.Int).Value = obj.Patient.Id;
                    //3-Executer la requete et recuperer les données
                    if (obj.Id != 0)
                        cmd.ExecuteScalar();
                    else
                        obj.Id = int.Parse(cmd.ExecuteScalar().ToString());

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
            return obj;
        }

        public Rdv remplirData(SqlDataReader sdr)
        {
            Rdv rdv = new Rdv()
            {
                Id = (int)sdr[0],
                DateRdv = (DateTime)sdr[1],
                TypeRdv = (TypeRdv)Enum.Parse(typeof(TypeRdv), sdr[2].ToString()),
                EtatRdv = (Etat)Enum.Parse(typeof(Etat), sdr[3].ToString()),
                Patient = patientRepo.findById((int)sdr[6]),
                Horaire = horaireRepo.findById((int)sdr[7])
            };
            if (rdv.TypeRdv == TypeRdv.Consultation)
            {
                rdv.Medecin = medecinRepo.findById((int)sdr[4]);
                rdv.Medecin.Rdvs.Add(rdv);

            }
            else
            {
                rdv.Rp = utilisateurRepo.findById((int)sdr[5]) as Rp;
            }

            return rdv;
        }

        public void update(Rdv obj)
        {
            
        }

        
       
    }
}
