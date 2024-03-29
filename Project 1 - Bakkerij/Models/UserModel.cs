using Microsoft.AspNetCore.Identity;

namespace Project_1___Bakkerij.Models
{
    public enum UserRole
    {
        Customer,
        OrderManager,
        Admin
    }

    public class UserModel : IdentityUser
    {
        public UserRole Role { get; set; }
    }
}
