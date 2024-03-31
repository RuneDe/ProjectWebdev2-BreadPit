using System.Collections.Generic;
using System.Linq;
using Project_1___Bakkerij.Data;
using Project_1___Bakkerij.Models;

namespace Project_1___Bakkerij.Services
{
    public class UserService
    {
        private readonly ContosoBreadContext _context;

        public UserService(ContosoBreadContext context)
        {
            _context = context;
        }

        public List<UserModel> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void CreateUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void ApproveUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                _context.SaveChanges();
            }
        }
    }
}
