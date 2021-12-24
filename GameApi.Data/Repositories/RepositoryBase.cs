using GameApi.Data.Context;
using GameApi.Domain.Interfaces;

namespace GameApi.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
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

        public void Atualiza(T newEntity)
        {
            _context.Update(newEntity);
            _context.SaveChanges();
        }

        public void Deleta(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
