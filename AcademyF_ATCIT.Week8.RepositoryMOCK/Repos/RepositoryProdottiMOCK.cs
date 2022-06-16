using AcademyF_ATCIT.Week8.Core.Entities;
using AcademyF_ATCIT.Week8.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.RepositoryMOCK.Repos
{
    public class RepositoryProdottiMOCK : IRepositoryProdotti
    {
        List<Prodotti> _prodotti = new List<Prodotti>
            {
                new Prodotti
                {
                    Name = "PC molto bello",
                    Tipo = "Elettronica",
                    Prezzo = 1420.69m
                },
                new Prodotti
                {
                    Name = "Pc non molto bello",
                    Tipo = "Elettronica",
                    Prezzo = 350.00m
                },
                new Prodotti
                {
                    Name = "Telefono mela",
                    Tipo = "Elettronica",
                    Prezzo = 1234.56m
                },
                new Prodotti
                {
                    Name = "Telefono Robot",
                    Tipo = "Elettronica",
                    Prezzo = 1600.00m
                },
                new Prodotti
                {
                    Name = "Telefono",
                    Tipo = "Elettronica",
                    Prezzo = 500.00m
                },
            };
        public bool Add(Prodotti entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Prodotti entity)
        {
            throw new NotImplementedException();
        }

        public List<Prodotti> GetAll()
        {
            return _prodotti;
        }

        public Prodotti GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prodotti> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Prodotti entity)
        {
            throw new NotImplementedException();
        }
    }
}
