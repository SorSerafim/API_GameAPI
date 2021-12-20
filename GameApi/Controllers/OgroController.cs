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
    public class OgroController : ControllerBase
    {
        private  IOgroRepository _repository;

        public OgroController(IOgroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<ReadOgroDto> RetornaTodos()
        {
            return _repository.RetornaTodosOsOgros();
        }

        [HttpPost]
        public void Adicionar(CreateOgroDto ogro)
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