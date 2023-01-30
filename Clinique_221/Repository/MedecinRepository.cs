using Clinique_221.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class MedecinRepository : BaseRepository, IMedecinRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM utilisateur where role='Medecin'";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM utilisateur where id=@idMedecin and role='Medecin'";
        private readonly string SQL_SELECT_BY_HEURE_AND_DATE = "SELECT utilisateur.* FROM utilisateur LEFT JOIN rdv ON utilisateur.id = rdv.medecin_id AND rdv.date_rdv = @date AND rdv.horaire_id = @idHoraire WHERE rdv.id IS NULL and utilisateur.role='Medecin'";

        ISpecialiteRepository specialiteRepository;
        public MedecinRepository(string chaineDeConnexion,ISpecialiteRepository specialiteRepository)
        {
            this.specialiteRepository = specialiteRepository;
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(Medecin obj)
        {
            throw new NotImplementedException();
        }

        public List<Medecin> findAll()
        {
            List<Medecin> medecins = new List<Medecin>();

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
                        Medecin medecin = remplirData(sdr);
                        medecins.Add(medecin);
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
            return medecins;
        }

        public List<Medecin> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Medecin> findByDateAndHeure(DateTime date, int idHoraire)
        {
            List<Medecin> medecins = new List<Medecin>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_HEURE_AND_DATE;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@idHoraire", SqlDbType.Int).Value = idHoraire;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Medecin medecin = remplirData(sdr);
                        medecins.Add(medecin);
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
            return medecins;
        }

        public Medecin findById(int id)
        {
            Medecin medecin = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idMedecin", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        medecin = remplirData(sdr);
                        
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
            return medecin;
        }

        public Medecin persist(Medecin obj)
        {
            throw new NotImplementedException();
        }

        public Medecin remplirData(SqlDataReader sdr)
        {
            Medecin medecin = new Medecin()
            {
                Id = (int)sdr[0],
                Email = (string)sdr[1],
                Password = (string)sdr[2],
                NomComplet = (string)sdr[3],
                Role = (Role)Enum.Parse(typeof(Role), sdr[4].ToString()),
                Sexe = (Sexe)Enum.Parse(typeof(Sexe), sdr[5].ToString()),
                TypeMedecin = (TypeMedecin)Enum.Parse(typeof(TypeMedecin), sdr[6].ToString()),
                Disponibilite = (Disponibilite)Enum.Parse(typeof(Disponibilite), sdr[8].ToString()),
            };
            medecin.Specialite=medecin.TypeMedecin==TypeMedecin.Generaliste?null:specialiteRepository.findById((int)sdr[7]);
            return medecin;
        }

        public void update(Medecin obj)
        {
            throw new NotImplementedException();
        }
    }
}
