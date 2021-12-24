using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IEquipamentoRepository : IRepository<Equipamento>
    {
        Equipamento RetornaEquipamentoPorId(int id);
        List<Equipamento> RetornaTodosOsEquipamentos();
    }
}