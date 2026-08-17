using WebApp1.Models;
using WebApp1.Repository.Interfaces;
using WebApp1.Services.Interfaces;

namespace WebApp1.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepo _taskRepo;

        public TaskService(ITaskRepo taskRepo)
        {
            _taskRepo = taskRepo;
        }

        public Taskss GetAllV1()
        {
            return _taskRepo.GetAllV1();
        }

        public Taskss GetAllV2()
        {
            return _taskRepo.GetAllV2();
        }
    }
}
