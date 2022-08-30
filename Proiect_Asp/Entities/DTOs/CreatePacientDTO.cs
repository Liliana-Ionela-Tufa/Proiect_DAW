using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Entities.DTOs
{
    public class CreatePacientDTO
    {
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string CNP { get; set; }


        public Adresa Adresa { get; set; }
    }
}
