using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class PlayerEquipamentoService : IPlayerEquipamentoService
    {
        private IPlayerRepository _IPlayerRepository;
        private IEquipamentoRepository _IEquipamentoRepository;
        private IPlayerEquipamentoRepository _IPlayerEquipamentoRepository;
        private IMapper _mapper;

        public PlayerEquipamentoService(IPlayerRepository playerRepository, IEquipamentoRepository equipamentoRepository, IPlayerEquipamentoRepository playerEquipamentoRepository, IMapper mapper)
        {
            _IPlayerRepository = playerRepository;
            _IEquipamentoRepository = equipamentoRepository;
            _IPlayerEquipamentoRepository = playerEquipamentoRepository;
            _mapper = mapper;
        }

        public void AdicionaPlayerEquipamento(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            var playerID = _IPlayerRepository.Retorna(playerEquipamentoDto.PlayerId);
            var equipamentoID = _IEquipamentoRepository.Retorna(playerEquipamentoDto.EquipamentoId);
            PlayerEquipamentos playerEquipamentos = new PlayerEquipamentos();
            if (playerID != null && equipamentoID != null)
            {
                playerEquipamentos.PlayerId = playerEquipamentoDto.PlayerId;
                playerEquipamentos.EquipamentoId = playerEquipamentoDto.EquipamentoId;
                _IPlayerEquipamentoRepository.Adiciona(playerEquipamentos);
            }
        }

        public List<ReadPlayerEquipamentoDto> RetornaTodosOsPlayerEquipamentos()
        {
            List<PlayerEquipamentos> list = _IPlayerEquipamentoRepository.RetornaTodos();
            List<ReadPlayerEquipamentoDto> listDto = new List<ReadPlayerEquipamentoDto>();
            foreach (PlayerEquipamentos playerEquipamentos in list)
            {
                ReadPlayerEquipamentoDto playerEquipamentoDto = new ReadPlayerEquipamentoDto();
                playerEquipamentoDto.Id = playerEquipamentos.Id;
                playerEquipamentoDto.PlayerId = playerEquipamentos.PlayerId;
                playerEquipamentoDto.EquipamentoId = playerEquipamentos.EquipamentoId;
                listDto.Add(playerEquipamentoDto);
            }
            return listDto;
        }

        public void DeletaPlayerEquipamento(int id)
        {
            PlayerEquipamentos playerEquipamentos = _IPlayerEquipamentoRepository.Retorna(id);
            if (playerEquipamentos != null)
            {
                _IPlayerEquipamentoRepository.Deleta(playerEquipamentos);
            }
        }

        public ReadPlayerEquipamentoDto RetornaPlayerEquipamentoPorId(int id)
        {
            PlayerEquipamentos playerEquipamentos = _IPlayerEquipamentoRepository.Retorna(id);
            if (playerEquipamentos != null)
            {
                ReadPlayerEquipamentoDto playerEquipamentoDto = _mapper.Map<ReadPlayerEquipamentoDto>(playerEquipamentos);
                return playerEquipamentoDto;
            }
            return null;
        }
    }
}