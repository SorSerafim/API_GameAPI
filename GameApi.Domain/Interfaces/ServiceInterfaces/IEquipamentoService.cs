using FluentResults;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IEquipamentoService
    {
        ReadEquipamentoDto RetornaEquipamentoPorId(int id);
        List<ReadEquipamentoDto> RetornaTodosOsEquipamentos();
        void AdicionaEquipamento(CreateEquipamentoDto equipamentoDto);
        Result AtualizaEquipamento(int id, CreateEquipamentoDto equipamentoDto);
        Result DeletaEquipamento(int id);
    }
}