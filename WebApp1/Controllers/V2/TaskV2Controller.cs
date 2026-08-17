using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Services.Interfaces;

namespace WebApp1.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("/api/v{version:apiVersion}/task")]
    public class TaskV2Controller : ControllerBase
    {
        private ITaskService _taskService;

        public TaskV2Controller(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("/api/v{version:apiVersion}/task")]
        public ActionResult GetAll()
        {
            if (_taskService.GetAllV2() == null)
            {
                return NotFound();
            }
            return Ok(_taskService.GetAllV2());
        }
    }
}
