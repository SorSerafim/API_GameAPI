using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Application.Services
{
    public class PlayerService
    {
        private IPlayerRepository _playerRepository;
        private IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public void AdicionaPlayer(CreatePlayerDto playerDto)
        {
            Player player = new Player();
            player.Nome = playerDto.Nome;
            player.Vida = playerDto.Vida;
            player.Level = playerDto.Level;
            _playerRepository.AdicionaPlayer(player);
        }

        public List<ReadPlayerDto> RetornaTodosOsPlayers()
        {
            List<Player> players = _playerRepository.RetornaTodosOsPlayers();
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
