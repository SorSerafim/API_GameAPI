namespace GameApi.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Adiciona(T entity);
        void Atualiza(T newEntity);
        void Deleta(T entity);
    }
}
