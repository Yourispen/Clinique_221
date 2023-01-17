using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface IAntecedentMedicalRepository : IRepository<AntecedentMedical>
    {
        List<AntecedentMedical> findAllByPatient(int id);
        void persistByPatient(Patient patient, List<AntecedentMedical> idAntecedentMedicaux);
    }
}
