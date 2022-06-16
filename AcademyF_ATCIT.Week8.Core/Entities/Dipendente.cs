using System;

namespace AcademyF_ATCIT.Week8.Core.Entities
{
    public class Dipendente
    {
        public int ID { get; set; } 
        public string CF { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
