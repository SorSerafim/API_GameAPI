using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Mvc;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private IUserService _service;

        public AuthorizationController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Adicionar(CreateUserDto createDto)
        {
            _service.AdicionaUser(createDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult RetornaPorId(int id)
        {
            ReadUserDto readDto = _service.RetornaUserPorId(id);
            if (readDto != null) return Ok(readDto);
            return NoContent();
        }
    }
}
