namespace Project_1___Bakkerij.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!; 
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public ICollection<OrderModel> Order { get; set; } = null!;
    }
}
