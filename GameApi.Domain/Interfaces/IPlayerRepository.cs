using GameApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Domain.Interfaces
{
    public interface IPlayerRepository
    {
        public void AdicionaPlayer(Player player);

        public List<Player> RetornaTodosOsPlayers();

        public void AtualizaPlayer(int id, Player novoPlayer);

        public void DeletaPlayer(int id);
    }
}
