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
        void AtualizaOgro(int id, CreateOgroDto ogroDto);
        void DeletaOgro(int id);
    }
}