namespace GestaoDeProdutos.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IStockRepository StockRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        void SaveChanges();
    }
}
