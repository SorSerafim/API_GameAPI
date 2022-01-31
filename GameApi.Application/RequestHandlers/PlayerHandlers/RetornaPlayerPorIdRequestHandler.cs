using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Shared.Dtos.Read;
using GameApi.Shared.Request;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GameApi.Application.RequestHandlers
{
    public class RetornaPlayerPorIdRequestHandler : IRequestHandler<RetornaPlayerPorIdRequest, ReadPlayerDto>
    {
        private IPlayerRepository _repository;
        private IMapper _mapper;

        public RetornaPlayerPorIdRequestHandler(IPlayerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<ReadPlayerDto> Handle(RetornaPlayerPorIdRequest request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _mapper.Map<ReadPlayerDto>(_repository.Retorna(request.Id)));
        }

    }
}
