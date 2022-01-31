using GameApi.Shared.Dtos.Create;
using MediatR;

namespace GameApi.Shared.Request
{
    public class AtualizaPlayerPorIdRequest : INotification
    {
        public AtualizaPlayerPorIdRequest(int id, CreatePlayerDto createDto)
        {
            Id = id;
            CreateDto = createDto;
        }

        public int Id { get; set; }
        public CreatePlayerDto CreateDto { get; set; }
    }
}
