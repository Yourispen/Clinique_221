using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface IMedicamentRepository : IRepository<Medicament>
    {
        Medicament findByCode(string code);
        List<Medicament> findByOrdonnance(Ordonnance ordonnance);
    }
}
