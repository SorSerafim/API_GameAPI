using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Shared.Request;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GameApi.Application.RequestHandlers.PlayerHandlers
{
    public class AdicionaPlayerRequestHandler : INotificationHandler<AdicionaPlayerRequest>
    {
        private IPlayerRepository _repository;
        private IMapper _mapper;

        public AdicionaPlayerRequestHandler(IPlayerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public Task Handle(AdicionaPlayerRequest notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => _repository.Adiciona(_mapper.Map<GameApi.Domain.Models.Player>(notification.CreateDto)));
        }
    }
}
