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
    public class ConsultationRepository : BaseRepository, IConsultationRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM consultation ORDER BY date_consultation DESC";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM consultation where id=@idConsultation ORDER BY date_consultation DESC";
        private readonly string SQL_SELECT_ALL_BY_DATE_AND_MEDECIN = @"SELECT * FROM consultation WHERE date_consultation=@dateConsultation and consultation.medecin_id=@idMedecin ORDER BY consultation.date_consultation DESC";
        private readonly string SQL_SELECT_ALL_BY_DATE_AND_CODE_PATIENT_AND_MEDECIN = @"SELECT consultation.* FROM consultation, utilisateur WHERE date_consultation=@dateConsultation and utilisateur.code like '%'+@codePatient+'%' and consultation.medecin_id=@idMedecin and consultation.patient_id=utilisateur.id ORDER BY consultation.date_consultation DESC";
        private readonly string SQL_SELECT_ALL_BY_ETAT_AND_DATE_AND_CODE_PATIENT_AND_MEDECIN = @"SELECT consultation.* FROM consultation, utilisateur WHERE consultation.date_consultation=@dateConsultation and utilisateur.code like '%'+@codePatient+'%' and consultation.medecin_id=@idMedecin and consultation.patient_id=utilisateur.id and consultation.etat_consultation=@etatConsultation ORDER BY consultation.date_consultation DESC";
        private readonly string SQL_SELECT_ALL_BY_ETAT_AND_DATE_AND_MEDECIN = @"SELECT consultation.* FROM consultation WHERE consultation.date_consultation=@dateConsultation and consultation.medecin_id=@idMedecin and consultation.etat_consultation=@etatConsultation ORDER BY consultation.date_consultation DESC";
        private readonly string SQL_INSERT = "INSERT INTO consultation(date_consultation,etat,ordonnance_id,heure,patient_id,medecin_id) values(@dateConsultation,@etatConsultation,@idOrdonnance,@heure,@idPatient,@idMedecin); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_UPDATE = "UPDATE consultation SET date_consultation=@dateConsultation,etat=@etatConsultation,ordonnance_id=@idOrdonnance, heure=@heure,patient_id=@idPatient, medecin_id=@idMedecin WHERE id=@idConsultation";

        IOrdonnanceRepository ordonnanceRepo;
        ITypePrestationRepository typePrestationRepo;
        IPatientRepository patientRepo;
        IMedecinRepository medecinRepo;

        public ConsultationRepository(string chaineDeConnexion,IOrdonnanceRepository ordonnanceRepo, ITypePrestationRepository typePrestationRepo, IPatientRepository patientRepo,IMedecinRepository medecinRepo)
        {
            ChaineDeConnexion = chaineDeConnexion;
            this.ordonnanceRepo = ordonnanceRepo;
            this.typePrestationRepo = typePrestationRepo;
            this.patientRepo = patientRepo;
            this.medecinRepo = medecinRepo;
        }

        public void delete(Consultation obj)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> findAll()
        {
            List<Consultation> consultations = new List<Consultation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Consultation consultation = remplirData(sdr);
                        consultations.Add(consultation);
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
            return consultations;
        }

        public List<Consultation> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> findAllByDate(DateTime date, int idMedecin)
        {
            List<Consultation> consultations = new List<Consultation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_DATE_AND_MEDECIN;
                    cmd.Parameters.Add("@dateConsultation", SqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = idMedecin;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Consultation consultation = remplirData(sdr);
                        consultations.Add(consultation);
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
            return consultations;
        }

        public List<Consultation> findAllByEtat(DateTime date, Etat etatConsultation, int idMedecin)
        {
            List<Consultation> consultations = new List<Consultation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_ETAT_AND_DATE_AND_MEDECIN;
                    cmd.Parameters.Add("@dateConsultation", SqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = idMedecin;
                    cmd.Parameters.Add("@etatConsultation", SqlDbType.VarChar).Value = etatConsultation.ToString();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Consultation consultation = remplirData(sdr);
                        consultations.Add(consultation);
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
            return consultations;
        }

        public List<Consultation> findAllByEtat(DateTime date, Etat etatConsultation, string codePatient, int idMedecin)
        {
            List<Consultation> consultations = new List<Consultation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_ETAT_AND_DATE_AND_CODE_PATIENT_AND_MEDECIN;
                    cmd.Parameters.Add("@dateConsultation", SqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = idMedecin;
                    cmd.Parameters.Add("@etatConsultation", SqlDbType.VarChar).Value = etatConsultation.ToString();
                    cmd.Parameters.Add("@codePatient", SqlDbType.Int).Value = codePatient;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Consultation consultation = remplirData(sdr);
                        consultations.Add(consultation);
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
            return consultations;
        }

        public List<Consultation> findAllByPatient(DateTime date, int idPatient, int idMedecin)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> findAllByPatient(DateTime date, string codePatient, int idMedecin)
        {
            List<Consultation> consultations = new List<Consultation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_DATE_AND_CODE_PATIENT_AND_MEDECIN;
                    cmd.Parameters.Add("@codePatient", SqlDbType.VarChar).Value = codePatient;
                    cmd.Parameters.Add("@dateConsultation", SqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = idMedecin;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Consultation consultation = remplirData(sdr);
                        consultations.Add(consultation);
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
            return consultations;
        }

        public Consultation findById(int id)
        {
            Consultation consultation = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idConsultation", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        consultation = remplirData(sdr);
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
            return consultation;
        }

        public Consultation persist(Consultation obj)
        {
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    if (obj.Id != 0)
                    {
                        cmd.CommandText = SQL_UPDATE;
                        cmd.Parameters.Add("@idConsultation", SqlDbType.Int).Value = obj.Id;
                    }
                    else
                    {
                        cmd.CommandText = SQL_INSERT;
                        cmd.Parameters.Add("@heure", SqlDbType.VarChar).Value = obj.Heure;
                    }
                    cmd.Parameters.Add("@dateConsultation", SqlDbType.Date).Value = obj.DateConsultation.Date;
                    cmd.Parameters.Add("@etatConsultation", SqlDbType.VarChar).Value = obj.EtatConsultation.ToString();
                    cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = obj.Medecin.Id;
                    cmd.Parameters.Add("@idPatient", SqlDbType.Int).Value = obj.Patient.Id;

                    if (obj.Ordonnance == null)
                    {
                        cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = obj.Ordonnance.Id;
                    }
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

                    connexion.Close();
                }
            }
            return obj;
        }

        public Consultation remplirData(SqlDataReader sdr)
        {
            Consultation consultation = new Consultation()
            {
                Id = (int)sdr[0],
                DateConsultation = (DateTime)sdr[1],
                EtatConsultation = (Etat)Enum.Parse(typeof(Etat), sdr[2].ToString()),
                Heure = (string)sdr[4],
                Patient = patientRepo.findById((int)sdr[5]),
                Medecin = medecinRepo.findById((int)sdr[6])
            };

            if (!sdr.IsDBNull(3))
            {
                Ordonnance ordonnance = ordonnanceRepo.findById((int)sdr[3]);
                ordonnance.Consultation = consultation;
                consultation.Ordonnance = ordonnance;
            }
            return consultation;
        }

        public void update(Consultation obj)
        {
            throw new NotImplementedException();
        }
    }
}
