using GameApi.Domain.Interfaces;
using GameApi.Shared.Request;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GameApi.Application.RequestHandlers
{
    public class DeletePlayerPorIdRequestHandler : INotificationHandler<DeletaPlayerPorIdRequest>
    {
        private IPlayerRepository _repository;

        public DeletePlayerPorIdRequestHandler(IPlayerRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(DeletaPlayerPorIdRequest notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => _repository.Deleta(_repository.Retorna(notification.Id)));
        }
    }
}
