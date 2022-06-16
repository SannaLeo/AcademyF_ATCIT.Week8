using AcademyF_ATCIT.Week8.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        List<Prodotti> GetAllProdotti();
        bool AggiungiDipendente(Dipendente dipendente);
        bool RimuoviDipendente(Dipendente dipendente);
        bool AggiornaDipendente(Dipendente dipendente);
        Dipendente PrendiUnDipendentePerID(int id);
        List<Dipendente> PrendiTuttiDipendente();
        User GetUserbyUsername(string username);
    }
}
