using Proiect_Asp.Data;
using Proiect_Asp.Entities.User;
using Proiect_Asp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Proiect_Asp.Repositories.SessionTokenRepository
{
    public class SessionTokenRepository : IGenericRepository<SessionToken>, ISessionTokenRepository
    {
        //public SessionTokenRepository(ProiectContext context) : base(context) { }
        public readonly ProiectContext _context;

        public void Create(SessionToken entity)
        {
            throw new NotImplementedException();
        }

        public void CreateRange(IEnumerable<SessionToken> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(SessionToken entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<SessionToken> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SessionToken> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SessionToken> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SessionToken> GetByJTI(string jti)
        {
            return await _context.SessionTokens.FirstOrDefaultAsync(t => t.Jti.Equals(jti));
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(SessionToken entity)
        {
            throw new NotImplementedException();
        }
    }
}
