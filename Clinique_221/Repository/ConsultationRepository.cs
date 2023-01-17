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
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM consultation where id=@idConsultation";

        IOrdonnanceRepository ordonnanceRepo;

        public ConsultationRepository(string chaineDeConnexion,IOrdonnanceRepository ordonnanceRepo)
        {
            ChaineDeConnexion = chaineDeConnexion;
            this.ordonnanceRepo = ordonnanceRepo;
        }

        public void delete(Consultation obj)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> findAll()
        {
            throw new NotImplementedException();
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
                        consultation = new Consultation()
                        {
                            Id = (int)sdr[0],
                            DateConsultation = (DateTime)sdr[1],
                            EtatConsultation = (Etat)Enum.Parse(typeof(Etat), sdr[2].ToString())
                        };
                        int idOrdonnance = (int)sdr[3];
                        if(idOrdonnance != 0)
                        {
                            Ordonnance ordonnance = ordonnanceRepo.findById(idOrdonnance);
                            ordonnance.Consultation=consultation;
                            consultation.Ordonnance=ordonnance;
                        }
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
            throw new NotImplementedException();
        }

        public Consultation remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(Consultation obj)
        {
            throw new NotImplementedException();
        }
    }
}
