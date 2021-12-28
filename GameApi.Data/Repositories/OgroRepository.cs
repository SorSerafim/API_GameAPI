using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;

namespace GameApi.Data.Repositories
{
    public class OgroRepository : RepositoryBase<Ogro>, IOgroRepository
    {
        public GameApiContext _context;

        public OgroRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }
    }
}