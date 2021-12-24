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
            Ogro ogro = _mapper.Map<Ogro>(ogroDto);
            _repository.Adiciona(ogro);
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

        public void AtualizaOgro(int id, CreateOgroDto ogroDto)
        {
            Ogro ogro = _repository.RetornaOgroPorId(id);
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
            Ogro ogro = _repository.RetornaOgroPorId(id);
            if(ogro != null)
            {
                _repository.Deleta(ogro);
            }
        }

        public Ogro RetornaOgroPorId(int id)
        {
            return _repository.RetornaOgroPorId(id);
        }
    }
}