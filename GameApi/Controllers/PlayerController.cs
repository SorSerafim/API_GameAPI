using GameApi.Application.Services;
using GameApi.Data.Context;
using GameApi.Data.Repositories;
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
    public class PlayerController : ControllerBase
    {
        private IPlayerRepository _repository;
        private PlayerService _service;

        public PlayerController(IPlayerRepository repository, PlayerService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public List<ReadPlayerDto> RetornaTodos()
        {
            return _service.RetornaTodosOsPlayers();
        }

        [HttpPost]
        public void Adicionar(CreatePlayerDto player)
        {
            _service.AdicionaPlayer(player);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _repository.DeletaPlayer(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, Player novoPlayer)
        {
            _repository.AtualizaPlayer(id, novoPlayer);
            return Ok();
        }
    }
}