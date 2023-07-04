namespace GestaoDeProdutos.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        List<TEntity> GetAll();
        List<TEntity> GetAll(Func<TEntity, bool> where);
        TEntity? GetById(TKey id);
        TEntity? Get(Func<TEntity, bool> where);
    }
}
