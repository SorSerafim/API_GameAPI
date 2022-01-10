using GameApi.Data.Context;
using GameApi.Domain.Interfaces.RepositoryInterfaces;
using GameApi.Domain.Models;

namespace GameApi.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private GameApiContext _context;

        public UserRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }
    }
}
