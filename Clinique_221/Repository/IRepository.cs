using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface IRepository<T>
    {
        List<T> findAll();
        List<T> findAllByDate(DateTime date);
        T findById(int id);
        T persist(T obj);
        void update(T obj);
        void delete(T obj);
        T remplirData(SqlDataReader sdr);

    }
}
