using GameApi.Domain.Interfaces.ServiceInterfaces;
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
        private IOgroService _service;

        public OgroController(IOgroService service)
        {
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
            _service.DeletaOgro(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, Ogro novoOgro)
        {
            _service.AtualizaOgro(id, novoOgro);
            return Ok();
        }
    }
}