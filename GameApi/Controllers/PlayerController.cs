using GameApi.Domain.Interfaces.ServiceInterfaces;
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
        private IPlayerService _service;

        public PlayerController(IPlayerService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Adicionar(CreatePlayerDto playerDto)
        {
            _service.AdicionaPlayer(playerDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult RetornaTodos()
        {
            List<ReadPlayerDto> listDto = _service.RetornaTodosOsPlayers();
            if(listDto != null) return Ok(listDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RetornaPorId(int id)
        {
            ReadPlayerDto playerDto = _service.RetornaPlayerPorId(id);
            if(playerDto != null) return Ok(playerDto);
            return NotFound();
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