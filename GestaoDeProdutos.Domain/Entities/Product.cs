namespace GestaoDeProdutos.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int StockId { get; set; }
        public int CategoryId { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Category Category { get; set; }
    }
}
