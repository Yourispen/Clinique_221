using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public enum Role
    {
       Admin,Rp,Secretaire,Medecin,Patient 
    }
    public enum Sexe
    {
        F,M
    }
    public class Utilisateur
    {
        private int id;
        private string email;
        private string password;
        private string nomComplet;
        private Role role;
        private Sexe sexe;

        public Utilisateur()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public Role Role { get => role; set => role = value; }
        public Sexe Sexe { get => sexe; set => sexe = value; }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
