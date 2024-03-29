namespace Project_1___Bakkerij.Models
{
    public class OrderManagerModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!; 
        public string Email { get; set; } = null!;
    }
}
