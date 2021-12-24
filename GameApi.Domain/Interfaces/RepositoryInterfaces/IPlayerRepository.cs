using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Player RetornaPlayerPorId(int id);
        List<Player> RetornaTodosOsPlayers();
    }
}
