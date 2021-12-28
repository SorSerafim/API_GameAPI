using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;

namespace GameApi.Data.Repositories
{
    public class PlayerEquipamentoRepository : RepositoryBase<PlayerEquipamentos>, IPlayerEquipamentoRepository
    {
        private GameApiContext _context;

        public PlayerEquipamentoRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }
    }
}