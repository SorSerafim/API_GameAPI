using GameApi.Data.Context;
using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Data.Repositories
{
    public class OgroRepository
    {
        public GameApiContext _context;

        public OgroRepository(GameApiContext context)
        {
            _context = context;
        }

        public void AdicionaOgro(Ogro ogro)
        {
            _context.Add(ogro);
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
