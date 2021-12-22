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

        public OgroRepository(GameApiContext context)
        {
            _context = context;
        }

        public void AdicionaOgro(Ogro ogro)
        {
            _context.Ogros.Add(ogro);
            _context.SaveChanges();
        }

        public List<Ogro> RetornaTodosOsOgros()
        {
            return _context.Ogros.ToList();
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
