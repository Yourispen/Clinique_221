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
    public class AntecedentMedicalRepository : BaseRepository, IAntecedentMedicalRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM antecedent_medical";
        private readonly string SQL_SELECT_ALL_BY_ID_PATIENT = "SELECT antecedent_medical.* FROM antecedent_medical,patient_antecedent_medical where patient_antecedent_medical.patient_id=@idPatient and patient_antecedent_medical.antecedent_medical_id=antecedent_medical.id";
        private readonly string SQL_INSERT = "INSERT INTO patient(nom_complet,role,sexe,code,date_naissance,type_patient,nom_parent) values(@nomCompletPatient,@rolePatient,@sexePatient,@codePatient,@dateNaissancePatient,@typePatient,@nomParentPatient)";
        private readonly string SQL_INSERT_BY_PATIENT = "INSERT INTO patient_antecedent_medical(patient_id,antecedent_medical_id) values(@idPatient,@idAntecedentMedical)";
        private readonly string SQL_UPDATE = "UPDATE antecedent_medical SET libelle=@libelle WHERE id=@idAntecedentMedical";
        private readonly string SQL_UPDATE_BY_PATIENT = "UPDATE patient_antecedent_medical SET antecedent_medical_id=@idAntecedentMedical WHERE patient_id=@idPatient";

        public AntecedentMedicalRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion=chaineDeConnexion;
        }

        public void delete(AntecedentMedical obj)
        {
            throw new NotImplementedException();
        }

        public List<AntecedentMedical> findAll()
        {
            List<AntecedentMedical> antMeds = new List<AntecedentMedical>();

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
                        AntecedentMedical antMed = new AntecedentMedical()
                        {
                            Id = (int)sdr[0],
                            Libelle = (string)sdr[1]
                        };
                        antMeds.Add(antMed);
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
            return antMeds;
        }

        public List<AntecedentMedical> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<AntecedentMedical> findAllByPatient(int id)
        {
            List<AntecedentMedical> antMeds = new List<AntecedentMedical>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_ID_PATIENT;
                    cmd.Parameters.Add("@idPatient", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        AntecedentMedical antMed = new AntecedentMedical()
                        {
                            Id = (int)sdr[0],
                            Libelle = (string)sdr[1]
                        };
                        antMeds.Add(antMed);
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
            return antMeds;
        }

        public AntecedentMedical findById(int id)
        {
            throw new NotImplementedException();
        }

        public AntecedentMedical persist(AntecedentMedical obj)
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
                        cmd.Parameters.Add("@idAntecedentMedical", SqlDbType.Int).Value = obj.Id;
                    }
                    else
                    {
                        cmd.CommandText = SQL_INSERT;
                    }
                    cmd.Parameters.Add("@libelle", SqlDbType.VarChar).Value = obj.Libelle;
                    cmd.ExecuteNonQuery();
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

        public void persistByPatient(Patient patient, List<AntecedentMedical> antecedentMedicaux)
        {
            foreach (var antMed in antecedentMedicaux)
            {
                //Console.WriteLine(antMed.Id);

                using (var connexion = new SqlConnection(ChaineDeConnexion))
                using (var cmd = connexion.CreateCommand())
                {
                    try
                    {
                        connexion.Open();
                        cmd.Connection = connexion;
                        
                        cmd.CommandText = SQL_INSERT_BY_PATIENT;
                        cmd.Parameters.Add("@idPatient", SqlDbType.Int).Value = patient.Id;
                        cmd.Parameters.Add("@idAntecedentMedical", SqlDbType.Int).Value = antMed.Id;
                        cmd.ExecuteNonQuery();
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
        }

        public AntecedentMedical remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(AntecedentMedical obj)
        {
            throw new NotImplementedException();
        }
    }
}
