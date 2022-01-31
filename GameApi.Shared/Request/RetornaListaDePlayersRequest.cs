using GameApi.Shared.Dtos.Read;
using MediatR;
using System.Collections.Generic;

namespace GameApi.Shared.Request
{
    public class RetornaListaDePlayersRequest : IRequest<List<ReadPlayerDto>>
    {
        public RetornaListaDePlayersRequest()
        {

        }
    }
}
