using AutoMapper;
using FluentResults;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public Result AtualizaPlayer(int id, CreatePlayerDto playerDto)
        {
            Player player = _repository.Retorna(id);
            if(player != null)
            {
                player.Nome = playerDto.Nome;
                player.Vida = playerDto.Vida;
                player.Level = playerDto.Level;
                _repository.Atualiza(player);
                return Result.Ok();
            }
            return Result.Fail("Player não encontrado!");
        }

        public Result DeletaPlayer(int id)
        {
            Player player = _repository.Retorna(id);
            if( player != null)
            {
                _repository.Deleta(player);
                return Result.Ok();
            }
            return Result.Fail("Player não encontrado!");
        }

        public ReadPlayerDto RetornaPlayerPorId(int id)
        {
            Player player = _repository.Retorna(id);
            if(player != null) return _mapper.Map<ReadPlayerDto>(player);
            return null;
        }

        public async Task<ReadPlayerDto> RetornaPlayerPorIdAsync(int id)
        {
            Player player = await _repository.PlayerPorIdAsync(id);
            if (player != null) return _mapper.Map<ReadPlayerDto>(player);
            return null;
        }
    }
}