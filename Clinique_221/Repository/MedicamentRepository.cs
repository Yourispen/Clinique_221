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
        private readonly string SQL_SELECT_ALL = "SELECT * FROM medicament";
        private readonly string SQL_SELECT_ALL_BY_ORDONNNANCE = "SELECT medicament.* FROM medicament, ordonnance_medicament_posologie where ordonnance_medicament_posologie.medicament_id = medicament.id and ordonnance_medicament_posologie.ordonnance_id=@idOrdonnance";
        private readonly string SQL_SELECT_BY_CODE = "SELECT * FROM medicament where code=@code";
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
            List<Medicament> medicaments = new List<Medicament>();

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
                        Medicament medicament = remplirData(sdr);
                        medicaments.Add(medicament);
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
            return medicaments;
        }

        public List<Medicament> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Medicament findByCode(string code)
        {
            Medicament medicament = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_CODE;
                    cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        medicament = remplirData(sdr);
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
                        medicament = remplirData(sdr);
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

        public List<Medicament> findByOrdonnance(Ordonnance ordonnance)
        {
            List<Medicament> medicaments = new List<Medicament>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_ORDONNNANCE;
                    cmd.Parameters.Add("@idOrdonnance", SqlDbType.Int).Value = ordonnance.Id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Medicament medicament = remplirData(sdr);
                        medicaments.Add(medicament);
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
            return medicaments;

        }

        public Medicament persist(Medicament obj)
        {
            throw new NotImplementedException();
        }

        public Medicament remplirData(SqlDataReader sdr)
        {
            Medicament medicament = new Medicament()
            {
                Id = (int)sdr[0],
                Code = (string)sdr[2],
                Nom = (string)sdr[1]
            };
            return medicament;
        }

        public void update(Medicament obj)
        {
            throw new NotImplementedException();
        }
    }
}
