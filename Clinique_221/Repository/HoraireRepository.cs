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
    public class HoraireRepository : BaseRepository, IHoraireRepository
    {
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM horaire where id=@idHoraire";
        private readonly string SQL_SELECT_DISPO_BY_DATE = "select horaire.* from horaire EXCEPT select horaire.* from horaire, rdv where horaire.id=rdv.horaire_id and rdv.date_rdv=@date and rdv.type_rdv=@typeRdv";
        private readonly string SQL_SELECT_ALL = "SELECT * FROM horaire";

        public HoraireRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Horaire obj)
        {
            throw new NotImplementedException();
        }

        public List<Horaire> findAll()
        {
            List<Horaire> horaires = new List<Horaire>();

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
                        Horaire horaire = remplirData(sdr);
                        horaires.Add(horaire);
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
            return horaires;
        }

        public List<Horaire> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Horaire> findAllByDateAndConsultation(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Horaire> findAllByDateAndHoraire(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Horaire> findAllByDateAndPrestation(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Horaire> findAllDispoByDate(DateTime date, TypeRdv typeRdv)
        {
            List<Horaire> horaires = new List<Horaire>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_DISPO_BY_DATE;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@typeRdv", SqlDbType.VarChar).Value = typeRdv.ToString();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Horaire horaire = remplirData(sdr);
                        horaires.Add(horaire);
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
            return horaires;
        }

        public Horaire findById(int id)
        {
            Horaire horaire = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idHoraire", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        horaire = remplirData(sdr);
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
            return horaire;
        }

        public Horaire persist(Horaire obj)
        {
            throw new NotImplementedException();
        }

        public Horaire remplirData(SqlDataReader sdr)
        {
            Horaire horaire = new Horaire()
            {
                Id = (int)sdr[0],
                Heure = (string)sdr[1]
            };
            return horaire;
        }

        public void update(Horaire obj)
        {
            throw new NotImplementedException();
        }
    }
}
