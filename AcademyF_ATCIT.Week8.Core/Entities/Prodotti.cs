using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.Core.Entities
{
    public class Prodotti
    {
        public string Name { get; set; }
        public string Tipo { get; set; }    
        public decimal Prezzo { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Tipo} - {Prezzo}€";
        }
    }
}
