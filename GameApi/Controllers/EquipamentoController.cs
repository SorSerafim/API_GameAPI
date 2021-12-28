using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Create;
using Microsoft.AspNetCore.Mvc;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EquipamentoController : ControllerBase
    {
        private IEquipamentoService _service;

        public EquipamentoController(IEquipamentoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Adicionar(CreateEquipamentoDto equipamento)
        {
            _service.AdicionaEquipamento(equipamento);
            return Ok();
        }

        [HttpGet]
        public IActionResult RetornaTodos()
        {
            return Ok(_service.RetornaTodosOsEquipamentos());
        }

        [HttpGet("{id}")]
        public IActionResult RetornaPorId(int id)
        {
            return Ok(_service.RetornaEquipamentoPorId(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _service.DeletaEquipamento(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, CreateEquipamentoDto equipamentoDto)
        {
            _service.AtualizaEquipamento(id, equipamentoDto);
            return Ok();
        }
    }
}