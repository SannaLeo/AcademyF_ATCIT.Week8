using AcademyF_ATCIT.Week8.Core.Entities;
using AcademyF_ATCIT.Week8.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.Core.BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryDipendente _repodips;
        private readonly IRepositoryUser _repouser;
        private readonly IRepositoryProdotti _repoprodotti;

        public BusinessLayer()
        {
            _repodips = DependencyContainer.Resolve<IRepositoryDipendente>();
            _repouser = DependencyContainer.Resolve<IRepositoryUser>();
            _repoprodotti = DependencyContainer.Resolve<IRepositoryProdotti>();
        }
        public bool AggiornaDipendente(Dipendente dipendente)
        { 
            return _repodips.Update(dipendente);
        }

        public bool AggiungiDipendente(Dipendente dipendente)
        {
            return _repodips.Add(dipendente);
        }

        public List<Prodotti> GetAllProdotti()
        {
            return _repoprodotti.GetAll(); 
        }

        public User GetUserbyUsername(string username)
        {
            return _repouser.GetByUserName(username);
        }

        public List<Dipendente> PrendiTuttiDipendente()
        {
            return _repodips.GetAll();
        }

        public Dipendente PrendiUnDipendentePerID(int id)
        {
            return _repodips.GetById(id);
        }

        public bool RimuoviDipendente(Dipendente dipendente)
        {
            return _repodips.Delete(dipendente);
        }
    }
}
