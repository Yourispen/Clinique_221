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
        private readonly string SQL_SELECT_ALL = "SELECT * FROM consultation";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM consultation where id=@idConsultation";
        private readonly string SQL_INSERT = "INSERT INTO consultation(date_consultation,etat,ordonnance_id) values(@dateConsultation,@etatConsultation,@idOrdonnance); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_UPDATE = "UPDATE consultation SET date_consultation=@dateConsultation,etat=@etatConsultation,ordonnance_id=@idOrdonnance WHERE id=@idPrestation";

        IOrdonnanceRepository ordonnanceRepo;
        ITypePrestationRepository typePrestationRepo;


        public ConsultationRepository(string chaineDeConnexion,IOrdonnanceRepository ordonnanceRepo, ITypePrestationRepository typePrestationRepo)
        {
            ChaineDeConnexion = chaineDeConnexion;
            this.ordonnanceRepo = ordonnanceRepo;
            this.typePrestationRepo = typePrestationRepo;
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
                    }
                    cmd.Parameters.Add("@dateConsultation", SqlDbType.Date).Value = obj.DateConsultation.Date;
                    cmd.Parameters.Add("@etatConsultation", SqlDbType.VarChar).Value = obj.EtatConsultation.ToString();
                    if (obj.Ordonnance == null)
                    {
                        cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = obj.Ordonnance.Id;
                    }
                    //cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = obj.Ordonnance.Id;
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
                EtatConsultation = (Etat)Enum.Parse(typeof(Etat), sdr[2].ToString())
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
