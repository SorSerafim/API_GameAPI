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
    public interface IPlayerRepository
    {
        public void AdicionaPlayer(CreatePlayerDto playerDto);
        public List<ReadPlayerDto> RetornaTodosOsPlayers();
        public void AtualizaPlayer(int id, Player novoPlayer);
        public void DeletaPlayer(int id);
    }
}
