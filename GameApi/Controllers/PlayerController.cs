using GameApi.Data.Context;
using GameApi.Data.Repositories;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
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
    public class PlayerController : ControllerBase
    {
        private IPlayerRepository _repository;

        public PlayerController( IPlayerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Player> RetornaTodos()
        {
            return _repository.RetornaTodosOsPlayers();
        }

        [HttpPost]
        public void Adicionar(Player player)
        {
            _repository.AdicionaPlayer(player);
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