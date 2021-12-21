using GameApi.Application.Services;
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
    [Route("[controller]")]
    [ApiController]
    public class PlayerEquipamentoController : ControllerBase
    {
        private IPlayerEquipamentoRepository _repository;
        private PlayerEquipamentoService _service;

        public PlayerEquipamentoController(IPlayerEquipamentoRepository repository, PlayerEquipamentoService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public List<PlayerEquipamentos> RetornaTodos()
        {
            return _repository.RetornaTodosOsPlayerEquipamentos();
        }

        [HttpPost]
        public void AdicionaEquipamentoAosPlayers(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            _service.AdicionaPlayerEquipamento(playerEquipamentoDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _repository.DeletaPlayerEquipamento(id);
            return Ok();
        }
    }
}
