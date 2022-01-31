using GameApi.Domain.Interfaces;
using GameApi.Shared.Request;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GameApi.Application.RequestHandlers.Player
{
    public class AtualizaPlayerPorIdRequestHandler : INotificationHandler<AtualizaPlayerPorIdRequest>
    {
        private IPlayerRepository _repository;

        public AtualizaPlayerPorIdRequestHandler(IPlayerRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(AtualizaPlayerPorIdRequest notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => _repository.Atualiza(_repository.Retorna(notification.Id)));
        }
    }
}
