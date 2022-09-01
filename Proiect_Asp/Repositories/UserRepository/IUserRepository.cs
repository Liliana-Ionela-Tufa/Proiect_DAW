using Proiect_Asp.Entities.User;
using Proiect_Asp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        IUserRepository User { get; }
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByEmail(string email);
        Task<User> GetByIdWithRoles(int id);

    }
}
