using GestaoDeProdutos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProdutos.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Stock> Stocks{ get; set; }
    }
}
