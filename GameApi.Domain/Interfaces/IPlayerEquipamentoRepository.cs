using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerEquipamentoRepository
    {
        public void AdicionaPlayerEquipamento(PlayerEquipamentos playerEquipamentos);
        public List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos();
        public void DeletaPlayerEquipamento(int id);
    }
}
