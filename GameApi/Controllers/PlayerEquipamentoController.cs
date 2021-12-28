using GameApi.Domain.Interfaces.ServiceInterfaces;
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
        private IPlayerEquipamentoService _service;

        public PlayerEquipamentoController(IPlayerEquipamentoService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AdicionaEquipamentoAosPlayers(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            _service.AdicionaPlayerEquipamento(playerEquipamentoDto);
        }

        [HttpGet]
        public List<PlayerEquipamentos> RetornaTodos()
        {
            return _service.RetornaTodosOsPlayerEquipamentos();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _service.DeletaPlayerEquipamento(id);
            return Ok();
        }
    }
}