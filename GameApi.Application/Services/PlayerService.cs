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
            Player player = _mapper.Map<Player>(playerDto);
            _repository.Adiciona(player);
        }

        public List<ReadPlayerDto> RetornaTodosOsPlayers()
        {
            List<Player> players = _repository.RetornaTodosOsPlayers();
            List<ReadPlayerDto> playerDtos = new List<ReadPlayerDto>();
            foreach(Player player in players)
            {
                ReadPlayerDto playerDto = new ReadPlayerDto();
                playerDto = _mapper.Map<ReadPlayerDto>(player);
                playerDtos.Add(playerDto);
            }
            return playerDtos;
        }

        public void AtualizaPlayer(int id, CreatePlayerDto playerDto)
        {
            Player player = _repository.RetornaPlayerPorId(id);
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
            Player player = _repository.RetornaPlayerPorId(id);
            if( player != null)
            {
                _repository.Deleta(player);
            }
        }

        public ReadPlayerDto RetornaPlayerPorId(int id)
        {
            Player player = _repository.RetornaPlayerPorId(id);
            if(player != null)
            {
                ReadPlayerDto playerDto = _mapper.Map<ReadPlayerDto>(player);
                return playerDto;
            }
            else
                return null;
        }
    }
}