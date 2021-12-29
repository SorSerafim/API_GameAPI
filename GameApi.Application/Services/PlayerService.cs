using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private IPlayerRepository _repository;
        private IMapper _mapper;

        public PlayerService(IPlayerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AdicionaPlayer(CreatePlayerDto playerDto)
        {
            _repository.Adiciona(_mapper.Map<Player>(playerDto));
        }

        public List<ReadPlayerDto> RetornaTodosOsPlayers()
        {
            return _mapper.Map<List<ReadPlayerDto>>(_repository.RetornaTodos());
        }

        public void AtualizaPlayer(int id, CreatePlayerDto playerDto)
        {
            Player player = _repository.Retorna(id);
            if(player != null)
            {
                player.Nome = playerDto.Nome;
                player.Vida = playerDto.Vida;
                player.Level = playerDto.Level;
                _repository.Atualiza(player);
            }
        }

        public void DeletaPlayer(int id)
        {
            Player player = _repository.Retorna(id);
            if( player != null) _repository.Deleta(player);
        }

        public ReadPlayerDto RetornaPlayerPorId(int id)
        {
            Player player = _repository.Retorna(id);
            if(player != null) return _mapper.Map<ReadPlayerDto>(player);
            return null;
        }
    }
}