using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerRepository
    {
        Player RetornaPlayerPorId(int id);
        void AdicionaPlayer(Player player);
        List<Player> RetornaTodosOsPlayers();
        void AtualizaPlayer(Player novoPlayer);
        void DeletaPlayer(Player player);
    }
}
