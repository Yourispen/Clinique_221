using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class OrdonnanceMedicament
    {
        private int qteMedicament;
        private Ordonnance ordonnance;
        private Medicament medicament;
        private Posologie posologie;

        public int QteMedicament { get => qteMedicament; set => qteMedicament = value; }
        public Ordonnance Ordonnance { get => ordonnance; set => ordonnance = value; }
        public Medicament Medicament { get => medicament; set => medicament = value; }
        public Posologie Posologie { get => posologie; set => posologie = value; }
    }
}
