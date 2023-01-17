using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Posologie
    {
        private int qteParPrise;
        private int nbrePrise;
        private string periode;
        private OrdonnanceMedicament ordonnanceMedicament;

        public int QteParPrise { get => qteParPrise; set => qteParPrise = value; }
        public string Periode { get => periode; set => periode = value; }
        public OrdonnanceMedicament OrdonnanceMedicament { get => ordonnanceMedicament; set => ordonnanceMedicament = value; }
        public int NbrePrise { get => nbrePrise; set => nbrePrise = value; }
    }
}
