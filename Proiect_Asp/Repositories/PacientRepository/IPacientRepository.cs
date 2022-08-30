using Proiect_Asp.Entities;
using Proiect_Asp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Repositories.AuthorRepository
{
    public interface IPacientRepository : IGenericRepository<Pacient>
    {
        object Pacient { get; }

        Task<Pacient> GetByFullName(string nume, string prenume);
        Task<List<Pacient>> GetAllPacientiWithAddress();
    }
}
