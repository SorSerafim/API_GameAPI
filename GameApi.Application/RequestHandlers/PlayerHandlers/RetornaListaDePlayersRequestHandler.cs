using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Shared.Dtos.Read;
using GameApi.Shared.Request;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GameApi.Application.RequestHandlers.Player
{
    public class RetornaListaDePlayersRequestHandler : IRequestHandler<RetornaListaDePlayersRequest, List<ReadPlayerDto>>
    {
        private IPlayerRepository _repository;
        private IMapper _mapper;

        public RetornaListaDePlayersRequestHandler(IPlayerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public Task<List<ReadPlayerDto>> Handle(RetornaListaDePlayersRequest request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _mapper.Map<List<ReadPlayerDto>>(_repository.RetornaTodos()));
        }
    }
}
