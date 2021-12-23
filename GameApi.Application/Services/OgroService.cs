using AutoMapper;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Application.Services
{
    public class OgroService
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
            Ogro ogro = _mapper.Map<Ogro>(ogroDto);
            _repository.AdicionaOgro(ogro);
        }

        public List<ReadOgroDto> RetornaTodosOsOgros()
        {
            List<Ogro> ogros = _repository.RetornaTodosOsOgros();
            List<ReadOgroDto> ogrosDtos = new List<ReadOgroDto>();
            foreach (Ogro ogro in ogros)
            {
                ReadOgroDto ogroDto = new ReadOgroDto();
                ogroDto = _mapper.Map<ReadOgroDto>(ogro);
                ogrosDtos.Add(ogroDto);
            }
            return ogrosDtos;
        }

        public void AtualizaOgro(int id, Ogro novoOgro)
        {
            Ogro ogro = _repository.RetornaOgroPorId(id);
            if(ogro != null)
            {
                ogro.Vida = novoOgro.Vida;
                ogro.Defesa = novoOgro.Defesa;
                ogro.Dano = novoOgro.Dano;
                _repository.AtualizaOgro(ogro);
            }
        }

        public void DeletaOgro(int id)
        {
            Ogro ogro = _repository.RetornaOgroPorId(id);
            if(ogro != null)
            {
                _repository.DeletaOgro(ogro);
            }
        }

        public Ogro RetornaOgroPorId(int id)
        {
            return _repository.RetornaOgroPorId(id);
        }
    }
}