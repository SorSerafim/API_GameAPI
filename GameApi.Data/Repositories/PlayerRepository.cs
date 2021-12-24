using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository 
    {
        public GameApiContext _context;

        public PlayerRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }

        public List<Player> RetornaTodosOsPlayers()
        {
            return _context.Players.Include(x => x.PlayerEquipamentos).ThenInclude(x => x.Equipamento).ToList();
        }

        public Player RetornaPlayerPorId(int id)
        {
            return _context.Players.FirstOrDefault(x => x.Id == id);
        }
    }
}