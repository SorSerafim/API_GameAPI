using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class PlayerService
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
            _repository.AdicionaPlayer(player);
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
    }
}
