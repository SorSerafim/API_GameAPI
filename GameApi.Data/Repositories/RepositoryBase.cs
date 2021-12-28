using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : Entidade
    {
        private GameApiContext _context;

        public RepositoryBase(GameApiContext context)
        {
            _context = context;
        }

        public void Adiciona(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual List<T> RetornaTodos()
        {
            return _context.Set<T>().ToList();
        }

        public T Retorna(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void Atualiza(T newEntity)
        {
            _context.Set<T>().Update(newEntity);
            _context.SaveChanges();
        }

        public void Deleta(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}