using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class EquipamentoService : IEquipamentoService
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
            _repository.Adiciona(_mapper.Map<Equipamento>(equipamentoDto));
        }

        public List<ReadEquipamentoDto> RetornaTodosOsEquipamentos()
        {
            return _mapper.Map<List<ReadEquipamentoDto>>(_repository.RetornaTodos());
        }

        public void AtualizaEquipamento(int id, CreateEquipamentoDto equipamentoDto)
        {
            Equipamento equipamento = _repository.Retorna(id);
            if(equipamento != null)
            {
                equipamento.Id = id;
                equipamento.Nome = equipamentoDto.Nome;
                equipamento.Dano = equipamentoDto.Dano;
                equipamento.Level = equipamentoDto.Level;
                _repository.Atualiza(equipamento);
            }
        }

        public void DeletaEquipamento(int id)
        {
            Equipamento equipamento = _repository.Retorna(id);
            if( equipamento != null) { _repository.Deleta(equipamento); }
        }

        public ReadEquipamentoDto RetornaEquipamentoPorId(int id)
        {
            Equipamento equipamento = _repository.Retorna(id);
            if(equipamento != null) { return _mapper.Map<ReadEquipamentoDto>(equipamento); }
            return null;
        }
    }
}