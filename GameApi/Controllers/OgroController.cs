using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Create;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Adicionar(CreateOgroDto ogroDto)
        {
            _service.AdicionaOgro(ogroDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult RetornaTodos()
        {
            return Ok(_service.RetornaTodosOsOgros());
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPorId(int id)
        {
            _service.DeletaOgro(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPorId(int id, CreateOgroDto ogroDto)
        {
            _service.AtualizaOgro(id, ogroDto);
            return Ok();
        }
    }
}