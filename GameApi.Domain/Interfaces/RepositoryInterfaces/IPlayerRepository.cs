using GameApi.Domain.Models;
using System.Threading.Tasks;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player> PlayerPorIdAsync(int id);
    }
}
