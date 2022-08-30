using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Entities
{
    public class Adresa
    {
        [Key]
        public int IdAdresa { get; set; }
        public string Tara { get; set; }
        public string Oras { get; set; }
        public string Strada { get; set; }
        public int NrStrada { get; set; }
        public int PacientId { get; set; }
        public Pacient Pacient { get; set; }


    }
}
