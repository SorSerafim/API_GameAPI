using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerEquipamentoRepository : IRepository<PlayerEquipamentos>
    {
        PlayerEquipamentos RetornaPlayerEquipamentoPorId(int id);
        List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos();
    }
}
