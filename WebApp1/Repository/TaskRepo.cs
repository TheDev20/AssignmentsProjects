using WebApp1.Models;
using WebApp1.Repository.Interfaces;

namespace WebApp1.Repository
{
    public class TaskRepo : ITaskRepo
    {
        private List<Taskss> _taskList = new List<Taskss>();

        public TaskRepo()
        {
            _taskList.AddRange(
                new Taskss
                {
                    Id = 1,
                    Title = "Task 1",
                    IsCompleted = false,
                    duedate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                },
                new Taskss
                {
                    Id = 2,
                    Title = "Task 2",
                    IsCompleted = true,
                    duedate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                },
                new Taskss
                {
                    Id = 3,
                    Title = "Task 3",
                    IsCompleted = false,
                    duedate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                }
            );
        }

        public Taskss? GetAllV1()
        {
            var task = _taskList.FirstOrDefault();

            if (task == null)
                return null;

            return new Taskss
            {
                Id = task.Id,
                Title = task.Title,
                IsCompleted = task.IsCompleted,
            };
        }

        public Taskss? GetAllV2()
        {
            var task1 = _taskList.FirstOrDefault();

            if (task1 == null)
                return null;

            return new Taskss
            {
                Id = task1.Id,
                Title = task1.Title,
                IsCompleted = task1.IsCompleted,
                duedate = task1.duedate,
                CreatedDate = task1.CreatedDate,
            };
        }
    }
}
