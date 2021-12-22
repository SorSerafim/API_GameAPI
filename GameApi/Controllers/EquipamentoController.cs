using GameApi.Application.Services;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
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
        private IEquipamentoRepository _repository;
        private EquipamentoService _service;

        public EquipamentoController(IEquipamentoRepository repository, EquipamentoService service)
        {
            _repository = repository;
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
            _repository.DeletaEquipamento(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, Equipamento novoEquipamento)
        {
            _repository.AtualizaEquipamento(id, novoEquipamento);
            return Ok();
        }
    }
}