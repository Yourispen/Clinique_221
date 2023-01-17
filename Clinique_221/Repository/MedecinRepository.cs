﻿using Clinique_221.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class MedecinRepository : BaseRepository, IMedecinRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM utilisateur where role='Medecin'";
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

        public Medecin findById(int id)
        {
            throw new NotImplementedException();
        }

        public Medecin persist(Medecin obj)
        {
            throw new NotImplementedException();
        }

        public Medecin remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(Medecin obj)
        {
            throw new NotImplementedException();
        }
    }
}
