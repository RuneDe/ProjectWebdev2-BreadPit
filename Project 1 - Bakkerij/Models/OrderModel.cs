namespace Project_1___Bakkerij.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } 
        public CustomerModel Customer { get; set; } 
        public List<OrderItemModel> OrderItems { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        // Andere relevante eigenschappen
    }
    public class OrderItemModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        // Andere relevante eigenschappen
    }
}
