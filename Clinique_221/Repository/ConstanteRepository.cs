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
    public class ConstanteRepository : BaseRepository, IConstanteRepository
    {
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM constante where id=@idConstante";
        private readonly string SQL_SELECT_ALL_BY_ORDONNANCE = "SELECT constante.* FROM constante,ordonnance_constante where ordonnance_constante.ordonnance_id=@idOrdonnance and constante.id=ordonnance_constante.constante_id";

        public ConstanteRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Constante obj)
        {
            throw new NotImplementedException();
        }

        public List<Constante> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Constante> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Constante> findAllByOrdonnance(Ordonnance ordonnance)
        {
            List<Constante> constantes = new List<Constante>();

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
                        Constante constante = new Constante()
                        {
                            Id = (int)sdr[0],
                            Libelle= (string)sdr[1]
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
            return constantes;
        }

        public Constante findById(int id)
        {
            Constante constante = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idConstante", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        constante = new Constante()
                        {
                            Id = (int)sdr[0],
                            Libelle = (string)sdr[1]
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
            return constante;
        }

        public Constante persist(Constante obj)
        {
            throw new NotImplementedException();
        }

        public Constante remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(Constante obj)
        {
            throw new NotImplementedException();
        }
    }
}
