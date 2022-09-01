using Microsoft.EntityFrameworkCore;
using Proiect_Asp.Data;
using Proiect_Asp.Entities.User;
using Proiect_Asp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private IUserRepository _user;

        public UserRepository(ProiectContext context) : base(context) { }
        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;
            }
        }
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdWithRoles(int id)
        {
            return await _context.Users
               .Include(u => u.UserRoles).
               ThenInclude(ur => ur.Role).
               FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }

    }
}
