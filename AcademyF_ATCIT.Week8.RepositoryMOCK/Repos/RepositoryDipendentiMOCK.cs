using AcademyF_ATCIT.Week8.Core.Entities;
using AcademyF_ATCIT.Week8.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyF_ATCIT.Week8.RepositoryMOCK.Repos
{
    public class RepositoryDipendentiMOCK : IRepositoryDipendente
    {
        private List<Dipendente> _dipendenti = new List<Dipendente>
        {
            new Dipendente
            {
                ID = 1,
                Firstname = "Giovanni",
                Lastname = "Giorgio",
                CF = "GRGGVN69H20F445G",
                DateOfBirth = new DateTime(1969,4,20)
            },
            new Dipendente
            {
                ID = 2,
                Firstname = "Giorno",
                Lastname= "Giovanna",
                CF = "GRNGVN85J16V552K",
                DateOfBirth= new DateTime(1985,4,16)
            },
            new Dipendente
            {
                ID= 3,
                Firstname = "Thanos",
                Lastname = "Titano",
                CF = "BRUH",
                DateOfBirth = new DateTime(1,1,1)
            }
        };
        public bool Add(Dipendente entity)
        {
            try
            {
                _dipendenti.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Dipendente CercaDipendentePerCF(string cf)
        {
            return _dipendenti.FirstOrDefault(d => d.CF == cf);
        }

        public bool Delete(Dipendente entity)
        {
            try
            {
                _dipendenti.Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Dipendente> GetAll()
        {
            return _dipendenti;
        }

        public Dipendente GetById(int id)
        {
            return _dipendenti.FirstOrDefault(d=>d.ID == id);
        }

        public List<Dipendente> GetByName(string name)
        {
            return _dipendenti.Where(d=>d.Firstname == name).ToList();
        }

        public bool Update(Dipendente entity)
        {
            try
            {
                var dip = _dipendenti.FirstOrDefault(d=>d.ID==entity.ID);
                dip = entity;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
