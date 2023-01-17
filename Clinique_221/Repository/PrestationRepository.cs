using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public class PrestationRepository : BaseRepository, IPrestationRepository
    {
        public void delete(Prestation obj)
        {
            throw new NotImplementedException();
        }

        public List<Prestation> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Prestation> findAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Prestation findById(int id)
        {
            throw new NotImplementedException();
        }

        public Prestation persist(Prestation obj)
        {
            throw new NotImplementedException();
        }

        public Prestation remplirData(SqlDataReader sdr)
        {
            throw new NotImplementedException();
        }

        public void update(Prestation obj)
        {
            throw new NotImplementedException();
        }
    }
}
