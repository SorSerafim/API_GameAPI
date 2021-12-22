using AutoMapper;
using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class OgroRepository : IOgroRepository
    {
        public GameApiContext _context;

        private IMapper _mapper;

        public OgroRepository(GameApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AdicionaOgro(CreateOgroDto ogroDto)
        {
            Ogro ogro = _mapper.Map<Ogro>(ogroDto);
            _context.Ogros.Add(ogro);
            _context.SaveChanges();
        }

        public List<ReadOgroDto> RetornaTodosOsOgros()
        {
            List<Ogro> ogros = _context.Ogros.ToList();
            List<ReadOgroDto> ogrosDtos = _mapper.Map<List<ReadOgroDto>>(ogros);
            return ogrosDtos;
        }

        public void AtualizaOgro(int id, Ogro novoOgro)
        {
            Ogro ogro = _context.Ogros.FirstOrDefault(x => x.Id == id);
            if (ogro != null)
            {
                ogro.Vida = novoOgro.Vida;
                ogro.Defesa = novoOgro.Defesa;
                ogro.Dano = novoOgro.Dano;
                _context.SaveChanges();
            }
        }

        public void DeletaOgro(int id)
        {
            Ogro ogro = _context.Ogros.FirstOrDefault(x => x.Id == id);
            if(ogro != null)
            {
                _context.Ogros.Remove(ogro);
                _context.SaveChanges();
            }
        }
    }
}
