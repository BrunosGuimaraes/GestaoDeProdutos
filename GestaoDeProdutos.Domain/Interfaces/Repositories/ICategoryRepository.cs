using GestaoDeProdutos.Domain.Entities;

namespace GestaoDeProdutos.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category, Guid>
    {
    }
}
