using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class EquipamentoRepository : RepositoryBase<Equipamento>, IEquipamentoRepository
    {
        private GameApiContext _context;

        public EquipamentoRepository(GameApiContext context) : base(context)
        {
            _context = context;
        }

        public List<Equipamento> RetornaTodosOsEquipamentos()
        {
            return _context.Equipamentos.Include(x => x.PlayerEquipamentos).ToList();
        }

        public Equipamento RetornaEquipamentoPorId(int id)
        {
            return _context.Equipamentos.FirstOrDefault(x => x.Id == id);
        }
    }
}