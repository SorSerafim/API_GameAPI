using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Adiciona(T entity);
        List<T> RetornaTodos();
        T Retorna(int id);
        void Atualiza(T newEntity);
        void Deleta(T entity);
    }
}
