using GameApi.Data.Context;
using GameApi.Data.Repositories;
using GameApi.Domain.Models;
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
    public class OgroController : ControllerBase
    {
        private readonly GameApiContext _context;

        private readonly OgroRepository _repository;

        public OgroController(GameApiContext context)
        {
            _context = context;

            _repository = new OgroRepository(_context);
        }

        [HttpGet]
        public List<Ogro> RetornaTodos()
        {
            return _repository.RetornaTodosOsOgros();
        }

        [HttpPost]
        public void Adicionar(Ogro ogro)
        {
            _repository.AdicionaOgro(ogro);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _repository.DeletaOgro(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, Ogro novoOgro)
        {
            _repository.AtualizaOgro(id, novoOgro);
            return Ok();
        }
    }
}