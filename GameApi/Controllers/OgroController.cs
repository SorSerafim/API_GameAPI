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
    public class OgroController : ControllerBase
    {
        private IOgroService _service;

        public OgroController(IOgroService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Adicionar(CreateOgroDto ogroDto)
        {
            _service.AdicionaOgro(ogroDto);
            return Ok();
        }

        [HttpGet]
        [Authorize]
        public IActionResult RetornaTodos()
        {
            List<ReadOgroDto> listDto = _service.RetornaTodosOsOgros();
            if(listDto != null) return Ok(listDto);
            return NotFound();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Manager")]
        public IActionResult DeletaPorId(int id)
        {
            Result resultado = _service.DeletaOgro(id);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Manager")]
        public IActionResult AtualizaPorId(int id, CreateOgroDto ogroDto)
        {
            Result resultado = _service.AtualizaOgro(id, ogroDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}