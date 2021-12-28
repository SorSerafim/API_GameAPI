using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Create;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult AdicionaEquipamentoAosPlayers(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            _service.AdicionaPlayerEquipamento(playerEquipamentoDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult RetornaTodos()
        {
            return Ok(_service.RetornaTodosOsPlayerEquipamentos());
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _service.DeletaPlayerEquipamento(id);
            return Ok();
        }
    }
}