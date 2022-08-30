using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Entities
{
    public class Programare
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdProgramare { get; set; }

        public string Data { get; set; }

        public bool Compensata { get; set; }

        public int PacientId { get; set; }

        public Pacient Pacient { get; set; }
        public ICollection<ProgramareDoctor> ProgramariDoctor { get; set; }

    }
}
