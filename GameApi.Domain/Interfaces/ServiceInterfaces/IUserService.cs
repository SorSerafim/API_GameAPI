using FluentResults;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IUserService
    {
        ReadUserDto RetornaUserPorId(int id);
        List<ReadUserDto> RetornaTodosOsUsers();
        void AdicionaUser(CreateUserDto createDto);
        Result AtualizaUser(int id, CreateUserDto createDto);
        Result DeletaUser(int id);
    }
}
