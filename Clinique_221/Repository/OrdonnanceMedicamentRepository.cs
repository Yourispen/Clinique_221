using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class OrdonnanceMedicamentRepository : BaseRepository, IOrdonnanceMedicamentRepository
    {
        private readonly string SQL_SELECT_ALL_BY_ORDONNANCE = "SELECT * FROM ordonnance_medicament_posologie where ordonnance_id=@idOrdonnance";

        private IMedicamentRepository medicamentRepo;

        public OrdonnanceMedicamentRepository(string chaineDeConnexion, IMedicamentRepository medicamentRepo)
        {
            ChaineDeConnexion = chaineDeConnexion;
            this.medicamentRepo = medicamentRepo;
        }

        public void delete(OrdonnanceMedicamentRepository obj)
        {
            throw new NotImplementedException();
        }

        public List<OrdonnanceMedicamentRepository> findAll()
        {
            throw new NotImplementedException();
        }

        public List<OrdonnanceMedicamentRepository> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<OrdonnanceMedicament> findAllByOrdonnance(Ordonnance ordonnance)
        {
            List<OrdonnanceMedicament> ordonnanceMedicaments = new List<OrdonnanceMedicament>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_ORDONNANCE;
                    cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = ordonnance.Id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        OrdonnanceMedicament ordonnanceMedicament = new OrdonnanceMedicament()
                        {
                            QteMedicament = (int)sdr[0],
                            Posologie=new Posologie()
                            {
                                QteParPrise = (int)sdr[1],
                                NbrePrise = (int)sdr[2],
                                Periode= (string)sdr[3]
                            },
                            Medicament = medicamentRepo.findById((int)sdr[5])
                        };
                        ordonnanceMedicament.Ordonnance = ordonnance;
                        ordonnanceMedicaments.Add(ordonnanceMedicament);
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
            return ordonnanceMedicaments;
        }

        public OrdonnanceMedicamentRepository findById(int id)
        {
            throw new NotImplementedException();
        }

        public OrdonnanceMedicamentRepository persist(OrdonnanceMedicamentRepository obj)
        {
            throw new NotImplementedException();
        }

        public OrdonnanceMedicamentRepository remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(OrdonnanceMedicamentRepository obj)
        {
            throw new NotImplementedException();
        }
    }
}
