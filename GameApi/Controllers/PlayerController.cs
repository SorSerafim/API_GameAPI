using FluentResults;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            if (readDto != null) return Ok(readDto);
            return NoContent();
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> RetornaPorIdAsync(int id)
        //{
        //    ReadPlayerDto readDto = await _service.RetornaPlayerPorIdAsync(id);
        //    if(readDto != null) return Ok(readDto);
        //    return NoContent();
        //} 

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            Result resultado = _service.DeletaPlayer(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, CreatePlayerDto createDto)
        {
            Result resultado = _service.AtualizaPlayer(id, createDto);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}