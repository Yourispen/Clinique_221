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
    public class PrestationRepository : BaseRepository, IPrestationRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM prestation";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM prestation WHERE id=@idPrestation";
        private readonly string SQL_INSERT = "INSERT INTO prestation(date_prestation,etat) values(@datePrestation,@etatPrestation); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_UPDATE = "UPDATE prestation SET date_prestation=@datePrestation,etat=@etatPrestation WHERE id=@idPrestation";
        private readonly string SQL_INSERT_PRESTATION_TYPE_PRESTATION = "INSERT INTO prestation_type_prestation(prestation_id,type_prestation_id) values(@idPrestation,@idTypePrestation);";

        ITypePrestationRepository typePrestationRepo;

        public PrestationRepository(string chaineDeconnexion, ITypePrestationRepository typePrestationRepo)
        {
            ChaineDeConnexion = chaineDeconnexion;
            this.typePrestationRepo = typePrestationRepo;
        }

        public void delete(Prestation obj)
        {
            throw new NotImplementedException();
        }

        public List<Prestation> findAll()
        {
            List<Prestation> prestations = new List<Prestation>();

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
                        Prestation prestation = remplirData(sdr);
                        prestations.Add(prestation);
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
            return prestations;
        }

        public List<Prestation> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Prestation findById(int id)
        {
            Prestation prestation = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idPrestation", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        prestation = remplirData(sdr);
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
            return prestation;
        }

        public void insertPrestationTypePrestation(Prestation prestation, TypePrestation typePrestation)
        {
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_INSERT_PRESTATION_TYPE_PRESTATION;
                    cmd.Parameters.Add("@idPrestation", SqlDbType.Int).Value = prestation.Id;
                    cmd.Parameters.Add("@idTypePrestation", SqlDbType.Int).Value = typePrestation.Id;
                    cmd.ExecuteScalar();
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
        }

        public Prestation persist(Prestation obj)
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
                        cmd.Parameters.Add("@idPrestation", SqlDbType.Int).Value = obj.Id;
                    }
                    else
                    {
                        cmd.CommandText = SQL_INSERT;
                    }
                    cmd.Parameters.Add("@datePrestation", SqlDbType.Date).Value = obj.DatePrestation.Date;
                    cmd.Parameters.Add("@etatPrestation", SqlDbType.VarChar).Value = obj.EtatPrestation.ToString();
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

        public Prestation remplirData(SqlDataReader sdr)
        {
            Prestation prestation = new Prestation()
            {
                Id = (int)sdr[0],
                DatePrestation = (DateTime)sdr[1],
                EtatPrestation = (Etat)Enum.Parse(typeof(Etat), sdr[2].ToString()),
            };
            prestation.TypePrestations = typePrestationRepo.findAllByPrestation(prestation);

            return prestation;
        }

        public void update(Prestation obj)
        {
            throw new NotImplementedException();
        }
    }
}
