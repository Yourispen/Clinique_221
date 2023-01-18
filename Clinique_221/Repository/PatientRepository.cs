using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Clinique_221.Repository
{
    public class PatientRepository : BaseRepository, IPatientRepository
    {
        private readonly string SQL_SELECT_ONE_BY_CODE = "SELECT * FROM utilisateur where code=@codePatient and role='Patient'";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM utilisateur where id=@idPatient and role='Patient'";
        private readonly string SQL_INSERT = "INSERT INTO utilisateur(nom_complet,role,sexe,code,date_naissance,type_patient,nom_parent) values(@nomCompletPatient,@rolePatient,@sexePatient,@codePatient,@dateNaissancePatient,@typePatient,@nomParentPatient); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_UPDATE = "UPDATE utilisateur SET nom_complet=@nomCompletPatient, role=@rolePatient, sexe=@sexePatient, code=@codePatient, date_naissance=@dateNaissancePatient,type_patient=@typePatient,nom_parent=@nomParentPatient WHERE id=@idPatient";
        
        IAntecedentMedicalRepository antecedentMedicalRepo;

        public PatientRepository(string chaineDeConnexion, IAntecedentMedicalRepository antecedentMedicalRepo)
        {
            ChaineDeConnexion = chaineDeConnexion;
            this.antecedentMedicalRepo = antecedentMedicalRepo;
        }

        public void delete(Patient obj)
        {
            throw new NotImplementedException();
        }

        public List<Patient> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Patient> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Patient findByCode(string code)
        {
            Patient patient = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ONE_BY_CODE;
                    cmd.Parameters.Add("@codePatient", SqlDbType.VarChar).Value = code;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        patient = new Patient()
                        {
                            Id = (int)sdr[0],
                            NomComplet = (string)sdr[3],
                            Role = (Role)Enum.Parse(typeof(Role), sdr[4].ToString()),
                            Sexe = (Sexe)Enum.Parse(typeof(Sexe), sdr[5].ToString()),
                            Code = (string)sdr[9],
                            DateNaissance = (DateTime)sdr[10],
                            TypePatient = (TypePatient)Enum.Parse(typeof(TypePatient), sdr[11].ToString()),
                    };
                        patient.NomParent = patient.TypePatient == TypePatient.Adulte ? null : (string)sdr[12];
                        patient.AntecedantMedicaux = antecedentMedicalRepo.findAllByPatient(patient.Id);
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
            return patient;
        }

        public Patient findById(int id)
        {
            Patient patient = null;
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_BY_ID;
                    cmd.Parameters.Add("@idPatient", SqlDbType.Int).Value = id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        patient = remplirData(sdr);
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
            return patient;
        }

        public Patient persist(Patient obj)
        {
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    if(obj.Id != 0)
                    {
                        cmd.CommandText = SQL_UPDATE;
                        cmd.Parameters.Add("@idPatient", SqlDbType.Int).Value = obj.Id;
                    }
                    else
                    {
                        cmd.CommandText = SQL_INSERT;
                    }
                    cmd.Parameters.Add("@nomCompletPatient", SqlDbType.VarChar).Value = obj.NomComplet;
                    cmd.Parameters.Add("@rolePatient", SqlDbType.VarChar).Value = obj.Role.ToString();
                    cmd.Parameters.Add("@sexePatient", SqlDbType.VarChar).Value = obj.Sexe.ToString();
                    cmd.Parameters.Add("@codePatient", SqlDbType.VarChar).Value = obj.Code;
                    cmd.Parameters.Add("@dateNaissancePatient", SqlDbType.Date).Value = obj.DateNaissance.Date;
                    cmd.Parameters.Add("@typePatient", SqlDbType.VarChar).Value = obj.TypePatient.ToString();
                    cmd.Parameters.Add("@nomParentPatient", SqlDbType.VarChar).Value = obj.NomParent;
                    //cmd.ExecuteNonQuery();
                    obj.Id= int.Parse(cmd.ExecuteScalar().ToString());
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

        public Patient remplirData(SqlDataReader sdr)
        {
            Patient patient = new Patient()
            {
                Id = (int)sdr[0],
                NomComplet = (string)sdr[3],
                Role = (Role)Enum.Parse(typeof(Role), sdr[4].ToString()),
                Sexe = (Sexe)Enum.Parse(typeof(Sexe), sdr[5].ToString()),
                Code = (string)sdr[9],
                DateNaissance = (DateTime)sdr[10],
                TypePatient = (TypePatient)Enum.Parse(typeof(TypePatient), sdr[11].ToString()),
            };
            patient.NomParent = patient.TypePatient == TypePatient.Adulte ? null : (string)sdr[12];
            patient.AntecedantMedicaux = antecedentMedicalRepo.findAllByPatient(patient.Id);

            return patient;
        }

        public void update(Patient obj)
        {
            
        }
    }
}
