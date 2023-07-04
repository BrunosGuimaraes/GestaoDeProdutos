using GestaoDeProdutos.Domain.Entities;

namespace GestaoDeProdutos.Domain.Interfaces.Repositories
{
    public interface IStockRepository : IBaseRepository<Stock, Guid>
    {
    }
}
