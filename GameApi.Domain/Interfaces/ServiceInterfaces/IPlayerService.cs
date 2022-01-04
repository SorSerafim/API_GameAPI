using FluentResults;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IPlayerService
    {
        ReadPlayerDto RetornaPlayerPorId(int id);
        Task<ReadPlayerDto> RetornaPlayerPorIdAsync(int id);
        List<ReadPlayerDto> RetornaTodosOsPlayers();
        void AdicionaPlayer(CreatePlayerDto playerDto);
        Result AtualizaPlayer(int id, CreatePlayerDto playerDto);
        Result DeletaPlayer(int id);
    }
}