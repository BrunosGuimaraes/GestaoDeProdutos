namespace GestaoDeProdutos.Domain.Entities
{
    public class Stock
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
