using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class OgroService : IOgroService
    {
        private IOgroRepository _repository;
        private IMapper _mapper;

        public OgroService(IOgroRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AdicionaOgro(CreateOgroDto ogroDto)
        {
            _repository.Adiciona(_mapper.Map<Ogro>(ogroDto));
        }

        public List<ReadOgroDto> RetornaTodosOsOgros()
        {
            return _mapper.Map<List<ReadOgroDto>>(_repository.RetornaTodos());
        }

        public void AtualizaOgro(int id, CreateOgroDto ogroDto)
        {
            Ogro ogro = _repository.Retorna(id);
            if(ogro != null)
            {
                ogro.Id = id;
                ogro.Vida = ogroDto.Vida;
                ogro.Defesa = ogroDto.Defesa;
                ogro.Dano = ogroDto.Dano;
                _repository.Atualiza(ogro);
            }
        }

        public void DeletaOgro(int id)
        {
            Ogro ogro = _repository.Retorna(id);
            if(ogro != null) { _repository.Deleta(ogro); }
        }

        public ReadOgroDto RetornaOgroPorId(int id)
        {
            Ogro ogro = _repository.Retorna(id);
            if (ogro != null) { return _mapper.Map<ReadOgroDto>(ogro); }
            return null;
        }
    }
}