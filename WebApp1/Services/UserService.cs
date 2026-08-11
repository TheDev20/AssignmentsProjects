using WebApp1.Models;
using WebApp1.Repository.Interfaces;
using WebApp1.Services.Interfaces;

namespace WebApp1.Services
{
    public class UserService : IUserService
    {
        private IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public void CreateUser(Users user)
        {
            // Logic to create a user
            _userRepo.CreateUser(user);
        }
    }
}
