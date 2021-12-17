using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentoController : ControllerBase
    {
        private IEquipamentoRepository _repository;

        public EquipamentoController(IEquipamentoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<ReadEquipamentoDto> RetornaTodos()
        {
            return _repository.RetornaTodosOsEquipamentos();
        }

        [HttpPost]
        public void Adicionar(CreateEquipamentoDto equipamento)
        {
            _repository.AdicionaEquipamento(equipamento);
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