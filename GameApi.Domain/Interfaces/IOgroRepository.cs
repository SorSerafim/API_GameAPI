using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IOgroRepository
    {
        public void AdicionaOgro(Ogro ogro);
        public List<Ogro> RetornaTodosOsOgros();
        public void AtualizaOgro(int id, Ogro novoOgro);
        public void DeletaOgro(int id);
    }
}
