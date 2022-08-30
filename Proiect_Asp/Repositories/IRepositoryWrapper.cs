using Proiect_Asp.Repositories.AuthorRepository;
using System;
using System.Threading.Tasks;

namespace Proiect_Asp.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        object SessionToken { get; set; }

        IPacientRepository Pacient { get; }

        Task SaveAsync();
        Task FirstOrDefaultAsync(Func<object, bool> p);
    }
}
