using WebApp1.Models;

namespace WebApp1.Repository.Interfaces
{
    public interface ITaskRepo
    {
        public Taskss GetAllV1();
        public Taskss GetAllV2();
    }
}
