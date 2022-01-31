using MediatR;

namespace GameApi.Shared.Request
{
    public class DeletaPlayerPorIdRequest : INotification
    {
        public DeletaPlayerPorIdRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
