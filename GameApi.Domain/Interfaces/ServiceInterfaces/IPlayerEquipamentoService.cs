using FluentResults;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IPlayerEquipamentoService
    {
        ReadPlayerEquipamentoDto RetornaPlayerEquipamentoPorId(int id);
        List<ReadPlayerEquipamentoDto> RetornaTodosOsPlayerEquipamentos();
        void AdicionaPlayerEquipamento(CreatePlayerEquipamentoDto playerEquipamentoDto);
        Result DeletaPlayerEquipamento(int id);
    }
}