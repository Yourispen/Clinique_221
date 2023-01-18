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
    public class TypePrestationRepository : BaseRepository, ITypePrestationRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM type_prestation";
        private readonly string SQL_SELECT_ALL_BY_PRESTATION = "SELECT type_prestation.* FROM prestation_type_prestation,type_prestation WHERE prestation_type_prestation.prestation_id=@idPrestation and prestation_type_prestation.type_prestation_id=type_prestation.id";
        private readonly string SQL_SELECT_ALL_BY_CONSULTATION = "SELECT type_prestation.* FROM consultation_type_prestation,type_prestation WHERE prestation_type_prestation.consultation_id=@idConsultation and prestation_type_prestation.type_prestation_id=type_prestation.id";
        private readonly string SQL_INSERT = "INSERT INTO type_prestation(libelle) values(@libelle); SELECT SCOPE_IDENTITY()";
        private readonly string SQL_UPDATE = "UPDATE type_prestation SET libelle=@libelle WHERE id=@idTypePrestation";


        public TypePrestationRepository(string chaineDeConnexion)
        {
            ChaineDeConnexion = chaineDeConnexion;
        }

        public void delete(TypePrestation obj)
        {
            throw new NotImplementedException();
        }

        public List<TypePrestation> findAll()
        {
            List<TypePrestation> typePrestations = new List<TypePrestation>();

            //1-Ouvrir la connexion
            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    //2-Preparer la requete
                    cmd.CommandText = SQL_SELECT_ALL;
                    //3-Executer la requete et recuperer les données
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //4-parcours de requete(select)=>Mapping relationnel vers Objet (de la base de données vers l'app)
                    while (sdr.Read())
                    {
                        //Mapping relationnel vers Objet(de la base de données vers l'app)
                        TypePrestation typePrestation = remplirData(sdr);
                        typePrestations.Add(typePrestation);
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

                    //5-Fermeture de la connexion
                    connexion.Close();
                }
            }
            return typePrestations;
        }

        public List<TypePrestation> findAllByConsultation(Consultation consultation)
        {
            List<TypePrestation> typePrestations = new List<TypePrestation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_CONSULTATION;
                    cmd.Parameters.Add("@idConsultation", SqlDbType.Int).Value = consultation.Id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        TypePrestation typePrestation = remplirData(sdr);
                        typePrestations.Add(typePrestation);
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
            return typePrestations;
        }

        public List<TypePrestation> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<TypePrestation> findAllByPrestation(Prestation prestation)
        {
            List<TypePrestation> typePrestations = new List<TypePrestation>();

            using (var connexion = new SqlConnection(ChaineDeConnexion))
            using (var cmd = connexion.CreateCommand())
            {
                try
                {
                    connexion.Open();
                    cmd.Connection = connexion;
                    cmd.CommandText = SQL_SELECT_ALL_BY_PRESTATION;
                    cmd.Parameters.Add("@idPrestation", SqlDbType.Int).Value = prestation.Id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        TypePrestation typePrestation = remplirData(sdr);
                        typePrestations.Add(typePrestation);
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
            return typePrestations;
        }

        public TypePrestation findById(int id)
        {
            throw new NotImplementedException();
        }

        public TypePrestation persist(TypePrestation obj)
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
                        cmd.Parameters.Add("@idTypePrestation", SqlDbType.Int).Value = obj.Id;
                    }
                    else
                    {
                        cmd.CommandText = SQL_INSERT;
                    }
                    cmd.Parameters.Add("@libelle", SqlDbType.VarChar).Value = obj.Libelle;
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

        public TypePrestation remplirData(SqlDataReader sdr)
        {
            TypePrestation typePrestation = new TypePrestation()
            {
                Id = (int)sdr[0],
                Libelle = (string)sdr[1]
            };
            return typePrestation;
        }

        public void update(TypePrestation obj)
        {
            throw new NotImplementedException();
        }
    }
}
