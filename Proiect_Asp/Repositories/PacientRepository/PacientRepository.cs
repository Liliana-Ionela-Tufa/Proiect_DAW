using Microsoft.EntityFrameworkCore;
using Proiect_Asp.Data;
using Proiect_Asp.Entities;
using Proiect_Asp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Repositories.AuthorRepository
{
    public class PacientRepository : GenericRepository<Pacient>, IPacientRepository
    {
        public PacientRepository(ProiectContext context) : base(context) { }

        public object Pacient => throw new NotImplementedException();

        public async Task<List<Pacient>> GetAllPacientiWithAddress()
        {
            return await _context.Pacienti.Include(pacient => pacient.Adresa).ToListAsync();
        }

        public async Task<Pacient> GetByFullName(string nume, string prenume)
        {
            return await _context.Pacienti
                .Where(pacient => pacient.Nume.Equals(nume))
                .Where(pacient => pacient.Prenume.Equals(prenume))
                .FirstOrDefaultAsync();
        }
    }
}
