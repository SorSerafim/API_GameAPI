using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class PlayerEquipamentoService 
    {
        private IPlayerRepository _IPlayerRepository;
        private IEquipamentoRepository _IEquipamentoRepository;
        private IPlayerEquipamentoRepository _IPlayerEquipamentoRepository;

        public PlayerEquipamentoService(IPlayerRepository playerRepository, IEquipamentoRepository equipamentoRepository, IPlayerEquipamentoRepository playerEquipamentoRepository)
        {
            _IPlayerRepository = playerRepository;
            _IEquipamentoRepository = equipamentoRepository;
            _IPlayerEquipamentoRepository = playerEquipamentoRepository;
        }

        public  void AdicionaPlayerEquipamento(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            var playerID = _IPlayerRepository.RetornaPlayerPorId(playerEquipamentoDto.PlayerId);
            var equipamentoID = _IEquipamentoRepository.RetornaEquipamentoPorId(playerEquipamentoDto.EquipamentoId);
            PlayerEquipamentos playerEquipamentos = new PlayerEquipamentos();
            if (playerID != null && equipamentoID != null)
            {
                playerEquipamentos.PlayerId = playerEquipamentoDto.PlayerId;
                playerEquipamentos.EquipamentoId = playerEquipamentoDto.EquipamentoId;
                _IPlayerEquipamentoRepository.AdicionaPlayerEquipamento(playerEquipamentos);
            }
        }

        public List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos()
        {
            List<PlayerEquipamentos> listaPlayerEquipamentos = _IPlayerEquipamentoRepository.RetornaTodosOsPlayerEquipamentos();
            return listaPlayerEquipamentos;
        }

        public void DeletaPlayerEquipamento(int id)
        {
            PlayerEquipamentos playerEquipamentos = _IPlayerEquipamentoRepository.RetornaPlayerEquipamentoPorId(id);
            if (playerEquipamentos != null)
            {
                _IPlayerEquipamentoRepository.DeletaPlayerEquipamento(playerEquipamentos);
            }
        }

        public PlayerEquipamentos RetornaPlayerEquipamentoPorId(int id)
        {
            return _IPlayerEquipamentoRepository.RetornaPlayerEquipamentoPorId(id);
        }
    }
}