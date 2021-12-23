using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class PlayerEquipamentoRepository : IPlayerEquipamentoRepository
    {
        private GameApiContext _context;

        public PlayerEquipamentoRepository(GameApiContext context)
        {
            _context = context;
        }

        public void AdicionaPlayerEquipamento(PlayerEquipamentos playerEquipamentos)
        {
            _context.PlayerEquipamentos.Add(playerEquipamentos);
            _context.SaveChanges();
        }

        public List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos()
        {
            return _context.PlayerEquipamentos.ToList(); ;
        }

        public void DeletaPlayerEquipamento(PlayerEquipamentos playerEquipamentos)
        {
            _context.Remove(playerEquipamentos);
            _context.SaveChanges();
        }
        public PlayerEquipamentos RetornaPlayerEquipamentoPorId(int id)
        {
            return _context.PlayerEquipamentos.FirstOrDefault(x => x.Id == id);
        }
    }
}