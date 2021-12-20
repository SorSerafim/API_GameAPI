using GameApi.Domain.Interfaces;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerEquipamentoController : ControllerBase
    {
        private IPlayerEquipamentoRepository _repository;

        public PlayerEquipamentoController(IPlayerEquipamentoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<PlayersDoEquipamento> RetornaTodos()
        {
            return _repository.RetornaTodosOsPlayersEquipamentos();
        }

        [HttpPost]
        public void AdicionaEquipamentoAosPlayers(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            _repository.AdicionaPlayerEquipamento(playerEquipamentoDto);
        }
    }
}
