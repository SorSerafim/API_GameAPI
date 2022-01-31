using GameApi.Shared.Dtos.Create;
using MediatR;

namespace GameApi.Shared.Request
{
    public class AdicionaPlayerRequest : INotification
    {
        public AdicionaPlayerRequest(CreatePlayerDto createDto)
        {
            CreateDto = createDto;
        }

        public CreatePlayerDto CreateDto { get; set; }
    }
}
