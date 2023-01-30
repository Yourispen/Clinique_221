using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface IHoraireRepository : IRepository<Horaire>
    {
        List<Horaire> findAllByDateAndConsultation(DateTime date);
        List<Horaire> findAllByDateAndPrestation(DateTime date);
        List<Horaire> findAllDispoByDate(DateTime date,TypeRdv typeRdv);
    }
}
