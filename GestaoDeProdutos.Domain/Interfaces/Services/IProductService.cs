using GestaoDeProdutos.Domain.Entities;

namespace GestaoDeProdutos.Domain.Interfaces.Services
{
    public interface IProductService : IBaseService<Product, Guid>
    {
    }
}
