using FluentResults;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IOgroService
    {
        ReadOgroDto RetornaOgroPorId(int id);
        List<ReadOgroDto> RetornaTodosOsOgros();
        void AdicionaOgro(CreateOgroDto ogroDto);
        Result AtualizaOgro(int id, CreateOgroDto ogroDto);
        Result DeletaOgro(int id);
    }
}