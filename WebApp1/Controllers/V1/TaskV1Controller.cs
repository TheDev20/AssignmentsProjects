using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Services;
using WebApp1.Services.Interfaces;

namespace WebApp1.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("/api/v{version:apiVersion}/task")]
    public class TaskV1Controller : ControllerBase
    {
        private ITaskService _taskService;

        public TaskV1Controller(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("/api/v{version:apiVersion}/task")]
        public ActionResult GetAll()
        {
            if (_taskService.GetAllV1() == null)
            {
                return NotFound();
            }
            return Ok(_taskService.GetAllV1());
        }
    }
}
