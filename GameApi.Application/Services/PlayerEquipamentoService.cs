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
        private IPlayerRepository _playerRepository;
        private IEquipamentoRepository _equipamentoRepository;
        private IPlayerEquipamentoRepository _repository;
        private IMapper _mapper;

        public PlayerEquipamentoService(IPlayerRepository playerRepository, IEquipamentoRepository equipamentoRepository, IPlayerEquipamentoRepository playerEquipamentoRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _equipamentoRepository = equipamentoRepository;
            _repository = playerEquipamentoRepository;
            _mapper = mapper;
        }

        public void AdicionaPlayerEquipamento(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            if (_playerRepository.Retorna(playerEquipamentoDto.PlayerId) != null && _equipamentoRepository.Retorna(playerEquipamentoDto.EquipamentoId) != null)
            {
                _repository.Adiciona(_mapper.Map<PlayerEquipamentos>(playerEquipamentoDto));
            }
        }

        public List<ReadPlayerEquipamentoDto> RetornaTodosOsPlayerEquipamentos()
        {
            return _mapper.Map<List<ReadPlayerEquipamentoDto>>(_repository.RetornaTodos());
        }

        public void DeletaPlayerEquipamento(int id)
        {
            PlayerEquipamentos playerEquipamentos = _repository.Retorna(id);
            if (playerEquipamentos != null) _repository.Deleta(playerEquipamentos);
        }

        public ReadPlayerEquipamentoDto RetornaPlayerEquipamentoPorId(int id)
        {
            PlayerEquipamentos playerEquipamentos = _repository.Retorna(id);
            if (playerEquipamentos != null) return _mapper.Map<ReadPlayerEquipamentoDto>(playerEquipamentos);
            return null;
        }
    }
}