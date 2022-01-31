using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApi.Data.Repositories
{
    public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository 
    {
        public GameApiContext _context;

        public PlayerRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }

        public override List<Player> RetornaTodos()
        {
            return _context.Players.Include(x => x.PlayerEquipamentos).ThenInclude(x => x.Equipamento).ToList();
        }

        public async Task<Player> PlayerPorIdAsync(int id)
        {
            return await _context.Players.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}