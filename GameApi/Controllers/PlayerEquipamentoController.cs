using FluentResults;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerEquipamentoController : ControllerBase
    {
        private IPlayerEquipamentoService _service;

        public PlayerEquipamentoController(IPlayerEquipamentoService service)
        {
            _service = service;
        }
        
        [HttpPost]
        [Authorize]
        public IActionResult AdicionaEquipamentoAosPlayers(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            _service.AdicionaPlayerEquipamento(playerEquipamentoDto);
            return Ok();
        }

        [HttpGet]
        [Authorize]
        public IActionResult RetornaTodos()
        {
            List<ReadPlayerEquipamentoDto> listDto = _service.RetornaTodosOsPlayerEquipamentos();
            if(listDto != null) return Ok(listDto);
            return NotFound();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeletaPorId(int id)
        {
            Result resultado = _service.DeletaPlayerEquipamento(id);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}