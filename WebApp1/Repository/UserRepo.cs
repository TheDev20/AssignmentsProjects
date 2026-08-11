using System.Collections.Generic;
using System.Linq;
using WebApp1.Models;
using WebApp1.Repository.Interfaces;

namespace WebApp1.Repository
{
    public class UserRepo : IUserRepo
    {
        private List<Users> _createUser;

        public UserRepo()
        {
            _createUser = new List<Users>();
        }

        public Users CreateUser(Users user)
        {
            _createUser.Add(user);
            return _createUser.Last();
        }

        public List<Users> GetAll()
        {
            foreach (var user in _createUser)
            {
                Console.WriteLine(
                    $"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}, Password: {user.Password}"
                );
            }
            return _createUser;
        }
    }
}
