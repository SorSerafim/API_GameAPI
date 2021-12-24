using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class PlayerEquipamentoRepository : RepositoryBase<PlayerEquipamentos>, IPlayerEquipamentoRepository
    {
        private GameApiContext _context;

        public PlayerEquipamentoRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }

        public List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos()
        {
            return _context.PlayerEquipamentos.ToList(); ;
        }

        public PlayerEquipamentos RetornaPlayerEquipamentoPorId(int id)
        {
            return _context.PlayerEquipamentos.FirstOrDefault(x => x.Id == id);
        }
    }
}