using GameApi.Application.Services;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerEquipamentoController : ControllerBase
    {
        private PlayerEquipamentoService _service;

        public PlayerEquipamentoController(PlayerEquipamentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<PlayerEquipamentos> RetornaTodos()
        {
            return _service.RetornaTodosOsPlayerEquipamentos();
        }

        [HttpPost]
        public void AdicionaEquipamentoAosPlayers(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            _service.AdicionaPlayerEquipamento(playerEquipamentoDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _service.DeletaPlayerEquipamento(id);
            return Ok();
        }
    }
}