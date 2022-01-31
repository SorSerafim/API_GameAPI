using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Request;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayerController : BaseController
    {
        public PlayerController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Adicionar(CreatePlayerDto createDto)
        {
            await _mediator.Publish(new AdicionaPlayerRequest(createDto));
            return Ok();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> RetornaTodos()
        {
            return Ok(await _mediator.Send(new RetornaListaDePlayersRequest()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> RetornaPorIdMediatR(int id)
        {
            return Ok(await _mediator.Send(new RetornaPlayerPorIdRequest(id)));
        } 

        [HttpDelete("{id}")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeletaPorId(int id)
        {
            await _mediator.Publish(new DeletaPlayerPorIdRequest(id));
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> AtualizaPorId(int id, CreatePlayerDto createDto)
        {
            await _mediator.Publish(new AtualizaPlayerPorIdRequest(id, createDto));
            return Ok();
        }
    }
}