using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerEquipamentoRepository
    {
        public void AdicionaPlayerEquipamento(PlayerEquipamentos playerEquipamentos);
        public List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos();
        public void DeletaPlayerEquipamento(int id);
    }
}
