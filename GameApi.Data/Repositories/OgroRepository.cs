using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class OgroRepository : RepositoryBase<Ogro>, IOgroRepository
    {
        public GameApiContext _context;

        public OgroRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }

        public List<Ogro> RetornaTodosOsOgros()
        {
            return _context.Ogros.ToList();
        }

        public Ogro RetornaOgroPorId(int id)
        {
            return _context.Ogros.FirstOrDefault(x => x.Id == id);
        }
    }
}