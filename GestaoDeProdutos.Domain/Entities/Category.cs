namespace GestaoDeProdutos.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
