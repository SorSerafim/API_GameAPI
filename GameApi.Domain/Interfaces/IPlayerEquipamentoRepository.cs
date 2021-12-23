using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerEquipamentoRepository
    {
        PlayerEquipamentos RetornaPlayerEquipamentoPorId(int id);
        void AdicionaPlayerEquipamento(PlayerEquipamentos playerEquipamentos);
        List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos();
        void DeletaPlayerEquipamento(PlayerEquipamentos playerEquipamentos);
    }
}
