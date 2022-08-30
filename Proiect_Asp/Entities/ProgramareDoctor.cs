using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Entities
{
    public class ProgramareDoctor
    {
        public int ProgramareId { get; set; }
        public int DoctorId { get; set; }

        public Programare Programare { get; set; }

        public Doctor Doctor { get; set; }
    }
}
