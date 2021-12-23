using GameApi.Application.Services;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EquipamentoController : ControllerBase
    {
        private EquipamentoService _service;

        public EquipamentoController(EquipamentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<ReadEquipamentoDto> RetornaTodos()
        {
            return _service.RetornaTodosOsEquipamentos();
        }

        [HttpPost]
        public void Adicionar(CreateEquipamentoDto equipamento)
        {
            _service.AdicionaEquipamento(equipamento);
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