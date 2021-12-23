using GameApi.Application.Services;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private PlayerService _service;

        public PlayerController(PlayerService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<ReadPlayerDto> RetornaTodos()
        {
            return _service.RetornaTodosOsPlayers();
        }

        [HttpPost]
        public void Adicionar(CreatePlayerDto playerDto)
        {
            _service.AdicionaPlayer(playerDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _service.DeletaPlayer(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, CreatePlayerDto playerDto)
        {
            _service.AtualizaPlayer(id, playerDto);
            return Ok();
        }
    }
}