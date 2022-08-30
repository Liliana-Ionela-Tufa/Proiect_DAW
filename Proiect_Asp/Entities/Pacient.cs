using Proiect_Asp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Entities
{
    public class Pacient
    {
        [Key]
        public int IdPacient { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string CNP { get; set; }

        public  ICollection<Programare> Programari{ get; set; }

        public Adresa Adresa { get; set; }
    }
}
