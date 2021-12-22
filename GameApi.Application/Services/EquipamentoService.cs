using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class EquipamentoService
    {
        private IEquipamentoRepository _repository;
        private IMapper _mapper;

        public EquipamentoService(IEquipamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AdicionaEquipamento(CreateEquipamentoDto equipamentoDto)
        {
            Equipamento equipamento = _mapper.Map<Equipamento>(equipamentoDto);
            _repository.AdicionaEquipamento(equipamento);
        }

        public List<ReadEquipamentoDto> RetornaTodosOsEquipamentos()
        {
            List<Equipamento> equipamentos = _repository.RetornaTodosOsEquipamentos();
            List<ReadEquipamentoDto> equipamentosDtos = _mapper.Map<List<ReadEquipamentoDto>>(equipamentos);
            return equipamentosDtos;
        }
    }
}
