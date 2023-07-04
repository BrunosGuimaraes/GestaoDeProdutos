using GestaoDeProdutos.Domain.Entities;

namespace GestaoDeProdutos.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Product, Guid>
    {
    }
}
