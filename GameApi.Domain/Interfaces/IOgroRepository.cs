using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IOgroRepository
    {
        Ogro RetornaOgroPorId(int id);
        void AdicionaOgro(Ogro ogro);
        List<Ogro> RetornaTodosOsOgros();
        void AtualizaOgro(Ogro novoOgro);
        void DeletaOgro(Ogro ogro);
    }
}
