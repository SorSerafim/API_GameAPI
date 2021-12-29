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
            if (_IPlayerRepository.Retorna(playerEquipamentoDto.PlayerId) != null && _IEquipamentoRepository.Retorna(playerEquipamentoDto.EquipamentoId) != null)
            {
                _IPlayerEquipamentoRepository.Adiciona(_mapper.Map<PlayerEquipamentos>(playerEquipamentoDto));
            }
        }

        public List<ReadPlayerEquipamentoDto> RetornaTodosOsPlayerEquipamentos()
        {
            return _mapper.Map<List<ReadPlayerEquipamentoDto>>(_IPlayerEquipamentoRepository.RetornaTodos());
        }

        public void DeletaPlayerEquipamento(int id)
        {
            PlayerEquipamentos playerEquipamentos = _IPlayerEquipamentoRepository.Retorna(id);
            if (playerEquipamentos != null) { _IPlayerEquipamentoRepository.Deleta(playerEquipamentos); }
        }

        public ReadPlayerEquipamentoDto RetornaPlayerEquipamentoPorId(int id)
        {
            PlayerEquipamentos playerEquipamentos = _IPlayerEquipamentoRepository.Retorna(id);
            if (playerEquipamentos != null) { return _mapper.Map<ReadPlayerEquipamentoDto>(playerEquipamentos); }
            return null;
        }
    }
}