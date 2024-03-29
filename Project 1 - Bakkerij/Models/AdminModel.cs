namespace Project_1___Bakkerij.Models
{
    public class AdminModel
    {
        public int Id { get; set; }
        public string AdminUsername { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
