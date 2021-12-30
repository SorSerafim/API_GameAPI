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
        public IActionResult Adicionar(CreatePlayerDto createDto)
        {
            _service.AdicionaPlayer(createDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult RetornaTodos()
        {
            List<ReadPlayerDto> listDto = _service.RetornaTodosOsPlayers();
            if(listDto != null) return Ok(listDto);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult RetornaPorId(int id)
        {
            ReadPlayerDto readDto = _service.RetornaPlayerPorId(id);
            if(readDto != null) return Ok(readDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            ReadPlayerDto readDto = _service.RetornaPlayerPorId(id);
            if (readDto != null)
            {
                _service.DeletaPlayer(id);
                return Ok();
            }
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, CreatePlayerDto createDto)
        {
            ReadPlayerDto readDto = _service.RetornaPlayerPorId(id);
            if(readDto != null)
            {
                _service.AtualizaPlayer(id, createDto);
                return Ok();
            }
            return NoContent();
        }
    }
}