using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Entities.DTOs
{
    public class PacientDTO
    {
        [Key]
        public int IdPacient { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string CNP { get; set; }

        public List<Programare> Programari { get; set; }

        public Adresa Adresa { get; set; }

        public PacientDTO(Pacient pacient)
        {
            this.IdPacient = pacient.IdPacient;
            this.Nume = pacient.Nume;
            this.Prenume = pacient.Prenume;
            this.CNP = pacient.CNP;
            this.Programari = new List<Programare>();
            this.Adresa = pacient.Adresa;

        }
    }
}
