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
        private readonly string SQL_SELECT_ALL_BY_DATE = @"SELECT * FROM prestation WHERE date_prestation=@datePrestation ORDER BY prestation.date_prestation DESC";
        private readonly string SQL_SELECT_ALL_BY_DATE_AND_CODE_PATIENT = @"SELECT prestation.* FROM prestation, rdv, utilisateur WHERE date_prestation=@datePrestation and utilisateur.code like '%'+@codePatient+'%' and rdv.patient_id=utilisateur.id and prestation.id=rdv.prestation_id ORDER BY prestation.date_prestation DESC";
        private readonly string SQL_SELECT_ALL_BY_ETAT_AND_DATE_AND_CODE_PATIENT = @"SELECT prestation.* FROM prestation, rdv, utilisateur WHERE rdv.date_prestation=@datePrestation and utilisateur.code like '%'+@codePatient+'%' and rdv.patient_id=utilisateur.id and prestation.id=rdv.prestation_id and prestation.etat_prestation=@etatPrestation ORDER BY prestation.date_prestation DESC";
        private readonly string SQL_SELECT_ALL_BY_ID_PATIENT = @"SELECT prestation.* FROM prestation, rdv where rdv.patient_id=@idPatient and prestation.id=rdv.prestation_id ORDER BY date_prestation DESC";
        private readonly string SQL_SELECT_ALL_BY_CODE_PATIENT = @"SELECT prestation.* FROM prestation, utilisateur where utilisateur.code like '%'+@codePatient+'%' and prestation.patient_id=utilisateur.id ORDER BY prestation.date_prestation DESC";
        private readonly string SQL_INSERT = "INSERT INTO prestation(date_prestation,etat,heure,patient_id) values(@datePrestation,@etatPrestation,@heure,@idPatient); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_UPDATE = "UPDATE prestation SET date_prestation=@datePrestation,etat=@etatPrestation,heure=@heure WHERE id=@idPrestation";
        private readonly string SQL_INSERT_PRESTATION_TYPE_PRESTATION = "INSERT INTO prestation_type_prestation(prestation_id,type_prestation_id) values(@idPrestation,@idTypePrestation);";
        private readonly string SQL_SELECT_BY_HEURE_AND_DATE = "SELECT * FROM prestation where date_prestation=@date and heure=@heure";

        ITypePrestationRepository typePrestationRepo;
        IPatientRepository patientRepo;

        public PrestationRepository(string chaineDeconnexion, ITypePrestationRepository typePrestationRepo, IPatientRepository patientRepo)
        {
            ChaineDeConnexion = chaineDeconnexion;
            this.typePrestationRepo = typePrestationRepo;
            this.patientRepo = patientRepo;
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
            List<Prestation> prestations = new List<Prestation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_DATE;
                    cmd.Parameters.Add("@datePrestation", SqlDbType.Date).Value = date;
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

        public List<Prestation> findAllByDate(string codePatient)
        {
            throw new NotImplementedException();
        }

        public List<Prestation> findAllByEtat(Etat etatPrestation)
        {
            throw new NotImplementedException();
        }

        public List<Prestation> findAllByPatient(int idPatient)
        {
            throw new NotImplementedException();
        }

        public List<Prestation> findAllByPatient(string codePatient)
        {
            List<Prestation> prestations = new List<Prestation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_CODE_PATIENT;
                    cmd.Parameters.Add("@codePatient", SqlDbType.VarChar).Value = codePatient;
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

        public List<Prestation> findByDateAndHeure(DateTime date, string heure)
        {
            List<Prestation> prestations = new List<Prestation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_HEURE_AND_DATE;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@heure", SqlDbType.VarChar).Value = heure;
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
                    cmd.Parameters.Add("@heure", SqlDbType.VarChar).Value = obj.Heure;
                    cmd.Parameters.Add("@datePrestation", SqlDbType.Date).Value = obj.DatePrestation.Date;
                    cmd.Parameters.Add("@etatPrestation", SqlDbType.VarChar).Value = obj.EtatPrestation.ToString();
                    cmd.Parameters.Add("@idPatient", SqlDbType.Int).Value = obj.Patient.Id;
                    if (obj.Id != 0)
                        cmd.ExecuteScalar();
                    else
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
                Heure = (string)sdr[3],
                Patient = patientRepo.findById((int)sdr[4])

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
