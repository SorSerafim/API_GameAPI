using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Create;
using Microsoft.AspNetCore.Mvc;

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
            return Ok(_service.RetornaTodosOsPlayers());
        }

        [HttpGet("{id}")]
        public IActionResult RetornaPorId(int id)
        {
            return Ok(_service.RetornaPlayerPorId(id));
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