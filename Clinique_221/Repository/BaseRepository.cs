using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class BaseRepository
    {
        private string chaineDeConnexion;

        public string ChaineDeConnexion { get => chaineDeConnexion; set => chaineDeConnexion = value; }

        public void ouvrirConnexion()
        {

        }
        public void fermerConnexion()
        {

        }
    }
}
