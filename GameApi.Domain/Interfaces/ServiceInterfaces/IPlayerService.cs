using FluentResults;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IPlayerService
    {
        ReadPlayerDto RetornaPlayerPorId(int id);
        List<ReadPlayerDto> RetornaTodosOsPlayers();
        void AdicionaPlayer(CreatePlayerDto playerDto);
        Result AtualizaPlayer(int id, CreatePlayerDto playerDto);
        Result DeletaPlayer(int id);
    }
}