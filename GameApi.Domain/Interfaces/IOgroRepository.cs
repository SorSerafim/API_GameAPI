using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Domain.Interfaces
{
    public interface IOgroRepository
    {
        public void AdicionaOgro(CreateOgroDto ogroDto);
        public List<ReadOgroDto> RetornaTodosOsOgros();
        public void AtualizaOgro(int id, Ogro novoOgro);
        public void DeletaOgro(int id);
    }
}
