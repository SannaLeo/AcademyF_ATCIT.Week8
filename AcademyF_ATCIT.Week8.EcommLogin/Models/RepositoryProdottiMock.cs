using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.EcommLogin.Models
{
    internal class RepositoryProdottiMock : IRepository<Prodotti>
    {
        private List<Prodotti> _repoProds;
        public bool Add(Prodotti entity)
        {
            _repoProds.Add(entity);
            return true;
        }

        public bool Delete(Prodotti entity)
        {
            _repoProds.Remove(entity);
            return false;
        }

        public List<Prodotti> GetAll()
        {
            return _repoProds;
        }

        public Prodotti GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prodotti> GetByName(string name)
        {
            return _repoProds.Where(p => p.Name.Contains(name)).ToList();
        }

        public bool Update(Prodotti entity)
        {
            var prod = _repoProds.FirstOrDefault(p=>p.Name==entity.Name);
            prod = entity;
            return true;
        }
    }
}
