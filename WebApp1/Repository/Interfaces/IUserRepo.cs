using WebApp1.Models;

namespace WebApp1.Repository.Interfaces
{
    public interface IUserRepo
    {
        public Users CreateUser(Users user);

        public List<Users> GetAll();
    }
}
