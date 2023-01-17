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
    public class MedicamentRepository : BaseRepository, IMedicamentRepository
    {
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM medicament where id=@idMedicament";

        public MedicamentRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Medicament obj)
        {
            throw new NotImplementedException();
        }

        public List<Medicament> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Medicament> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Medicament findById(int id)
        {
            Medicament medicament = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idMedicament", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        medicament = new Medicament()
                        {
                            Id = (int)sdr[0],
                            Code = (string)sdr[2],
                            Nom = (string)sdr[1]
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

                    connexion.Close();
                }
            }
            return medicament;
        }

        public Medicament persist(Medicament obj)
        {
            throw new NotImplementedException();
        }

        public Medicament remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(Medicament obj)
        {
            throw new NotImplementedException();
        }
    }
}
