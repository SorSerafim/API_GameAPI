using GameApi.Shared.Dtos.Read;
using MediatR;

namespace GameApi.Shared.Request
{
    public class RetornaPlayerPorIdRequest : IRequest<ReadPlayerDto>
    {
        public RetornaPlayerPorIdRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
