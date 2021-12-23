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
            List<ReadEquipamentoDto> equipamentosDtos = new List<ReadEquipamentoDto>();
            foreach (Equipamento equipamento in equipamentos)
            {
                ReadEquipamentoDto readEquipamentoDto = new ReadEquipamentoDto();
                readEquipamentoDto = _mapper.Map<ReadEquipamentoDto>(equipamento);
                equipamentosDtos.Add(readEquipamentoDto);
            }
            return equipamentosDtos;
        }

        public void AtualizaEquipamento(int id, CreateEquipamentoDto equipamentoDto)
        {
            Equipamento equipamento = _repository.RetornaEquipamentoPorId(id);
            if(equipamento != null)
            {
                equipamento.Nome = equipamentoDto.Nome;
                equipamento.Dano = equipamentoDto.Dano;
                equipamento.Level = equipamentoDto.Level;
                _repository.AtualizaEquipamento(equipamento);
            }
        }

        public void DeletaEquipamento(int id)
        {
            Equipamento equipamento = _repository.RetornaEquipamentoPorId(id);
            if( equipamento != null)
            {
                _repository.DeletaEquipamento(equipamento);
            }
        }

        public Equipamento RetornaEquipamentoPorId(int id)
        {
            return _repository.RetornaEquipamentoPorId(id);
        }
    }
}