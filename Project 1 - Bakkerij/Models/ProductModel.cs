namespace Project_1___Bakkerij.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        // Andere relevante eigenschappen
    }
}
