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
    public class OgroController : ControllerBase
    {
        private  IOgroRepository _repository;
        private OgroService _service;

        public OgroController(IOgroRepository repository, OgroService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public List<ReadOgroDto> RetornaTodos()
        {
            return _service.RetornaTodosOsOgros();
        }

        [HttpPost]
        public void Adicionar(CreateOgroDto ogroDto)
        {
            _service.AdicionaOgro(ogroDto);
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