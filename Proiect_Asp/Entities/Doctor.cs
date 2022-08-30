using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Entities
{
    public class Doctor
    {
        [Key]
        public int IdDoctor { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Specializare { get; set; }

        public ICollection<ProgramareDoctor> ProgramariDoctor { get; set; }
    }
}
