using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Services;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private IUserService _service;
        private TokenService _token;

        public AuthorizationController(IUserService service, TokenService tokenService)
        {
            _service = service;
            _token = tokenService;
        }

        [HttpPost]
        public IActionResult Adicionar(CreateUserDto createDto)
        {
            _service.AdicionaUser(createDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult RetornaPorId(int id)
        {
            ReadUserDto readDto = _service.RetornaUserPorId(id);
            if (readDto != null) return Ok(readDto);
            return NoContent();
        }

        [HttpGet("RetornaTodosOsUsers")]
        public IActionResult RetornaTodos()
        {
            List<ReadUserDto> listDto = _service.RetornaTodosOsUsers();
            if (listDto != null) return Ok(listDto);
            return NoContent();
        }

        [HttpGet("Autenticar")]
        [AllowAnonymous]
        public string GetAutenticar(string username, string password)
        {
            return _token.GenerateToken(_service.Get(username, password));
        }
    }
}
