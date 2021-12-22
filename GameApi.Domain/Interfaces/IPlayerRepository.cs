using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerRepository
    {
        public Player RetornaPlayerPorId(int id);
        public void AdicionaPlayer(Player player);
        public List<Player> RetornaTodosOsPlayers();
        public void AtualizaPlayer(int id, Player novoPlayer);
        public void DeletaPlayer(int id);
    }
}
