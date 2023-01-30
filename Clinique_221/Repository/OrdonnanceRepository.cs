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
    public class OrdonnanceRepository : BaseRepository, IOrdonnanceRepository
    {
        private readonly string SQL_INSERT = "INSERT INTO ordonnance(date_ordonnance) values(@dateOrdonnance); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM ordonnance where id=@idOrdonnance";
        private readonly string SQL_SELECT_BY_CONSULTATION = "SELECT * FROM ordonnance where id=@idOrdonnance";

        private IOrdonnanceMedicamentRepository ordonnanceMedicamentRepo;
        private IConstanteRepository constanteRepo;

        public OrdonnanceRepository(string chaineDeConnexion, IOrdonnanceMedicamentRepository ordonnanceMedicamentRepo, IConstanteRepository constanteRepo)
        {
            ChaineDeConnexion = chaineDeConnexion;
            this.ordonnanceMedicamentRepo = ordonnanceMedicamentRepo;
            this.constanteRepo = constanteRepo;
        }

        public void delete(Ordonnance obj)
        {
            throw new NotImplementedException();
        }

        public List<Ordonnance> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Ordonnance> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Ordonnance findById(int id)
        {
            Ordonnance ordonnance = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        ordonnance = new Ordonnance()
                        {
                            Id = (int)sdr[0],
                            DateOrdonnance = (DateTime)sdr[1],
                        };
                    }
                    //ordonnance.OrdonnanceMedicament = ordonnanceMedicamentRepo.findAllByOrdonnance(ordonnance);
                    //ordonnance.Constantes = constanteRepo.findAllByOrdonnance(ordonnance);
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
            return ordonnance;
        }

        public Ordonnance persist(Ordonnance obj)
        {
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    
                        cmd.CommandText = SQL_INSERT;
                        cmd.Parameters.Add("@dateOrdonnance", SqlDbType.Date).Value = obj.DateOrdonnance;
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

        public Ordonnance remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(Ordonnance obj)
        {
            throw new NotImplementedException();
        }
    }
}
