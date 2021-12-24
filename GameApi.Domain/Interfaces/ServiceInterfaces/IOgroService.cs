using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IOgroService
    {
        Ogro RetornaOgroPorId(int id);
        List<ReadOgroDto> RetornaTodosOsOgros();
        void AdicionaOgro(CreateOgroDto ogroDto);
        void AtualizaOgro(int id, Ogro novoOgro);
        void DeletaOgro(int id);
    }
}