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
    public class EquipamentoController : ControllerBase
    {
        private IEquipamentoService _service;

        public EquipamentoController(IEquipamentoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Adicionar(CreateEquipamentoDto equipamento)
        {
            _service.AdicionaEquipamento(equipamento);
            return Ok();
        }

        [HttpGet]
        [Authorize]
        public IActionResult RetornaTodos()
        {
            List<ReadEquipamentoDto> listDto = _service.RetornaTodosOsEquipamentos();
            if(listDto != null) return Ok(listDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult RetornaPorId(int id)
        {
            ReadEquipamentoDto equipamentoDto = _service.RetornaEquipamentoPorId(id);
            if(equipamentoDto != null) return Ok(equipamentoDto);
            return NotFound();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Manager")]
        public IActionResult DeletaPorId(int id)
        {
            Result resultado = _service.DeletaEquipamento(id);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Manager")]
        public IActionResult AtualizaPorId(int id, CreateEquipamentoDto equipamentoDto)
        {
            Result resultado = _service.AtualizaEquipamento(id, equipamentoDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}