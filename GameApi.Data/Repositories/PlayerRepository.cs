using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public GameApiContext _context;

        public PlayerRepository(GameApiContext context)
        {
            _context = context;
        }

        public void AdicionaPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public List<Player> RetornaTodosOsPlayers()
        {
            return _context.Players.Include(x => x.PlayerEquipamentos).ThenInclude(x => x.Equipamento).ToList();
        }

        public void AtualizaPlayer(Player novoPlayer)
        {
            _context.Update(novoPlayer);
            _context.SaveChanges();
        }

        public void DeletaPlayer(Player player)
        {
            _context.Remove(player);
            _context.SaveChanges();
        }

        public Player RetornaPlayerPorId(int id)
        {
            return _context.Players.FirstOrDefault(x => x.Id == id);
        }
    }
}