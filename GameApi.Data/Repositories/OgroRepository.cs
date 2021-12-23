using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
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

        public void AtualizaOgro(Ogro novoOgro)
        {
            _context.Update(novoOgro);
            _context.SaveChanges();
        }

        public void DeletaOgro(Ogro ogro)
        {
            _context.Remove(ogro);
            _context.SaveChanges();
        }

        public Ogro RetornaOgroPorId(int id)
        {
            return _context.Ogros.FirstOrDefault(x => x.Id == id);
        }
    }
}