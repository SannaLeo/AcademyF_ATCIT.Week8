using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.EcommLogin.Models
{
    internal interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetByName(string name);
        T GetById(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
