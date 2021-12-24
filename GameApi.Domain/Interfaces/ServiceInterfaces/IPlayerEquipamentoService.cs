using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IPlayerEquipamentoService
    {
        PlayerEquipamentos RetornaPlayerEquipamentoPorId(int id);
        List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos();
        void AdicionaPlayerEquipamento(CreatePlayerEquipamentoDto playerEquipamentoDto);
        void DeletaPlayerEquipamento(int id);
    }
}