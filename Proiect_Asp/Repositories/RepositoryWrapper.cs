using Proiect_Asp.Data;
using Proiect_Asp.Repositories.AuthorRepository;
using System;
using System.Threading.Tasks;

namespace Proiect_Asp.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ProiectContext _context;
        private IUserRepository _user;
        private IPacientRepository _pacient;

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;
            }
        }

        public object SessionToken { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Task FirstOrDefaultAsync(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
       
        public IPacientRepository Pacient
        {
            get
            {
                if (_pacient == null) _pacient = new PacientRepository(_context);
                return _pacient;
            }

        }

        //IPacientRepository IRepositoryWrapper.Pacient => throw new NotImplementedException();
    }
}
