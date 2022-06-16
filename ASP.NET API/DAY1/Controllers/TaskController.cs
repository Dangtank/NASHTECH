using DAY1.DTO;
using DAY1.Models;
using DAY1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DAY1.Controllers
{
    [Route("task")]
    public class TaskController : ControllerBase
    {
        private ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost("")]
        public TaskModel CreateTask(string title, bool isCompleted)
        {
            return _taskService.Create(title, isCompleted);
        }

        [HttpGet("/get-all")]
        public List<TaskModel> GetAll()
        {
            return _taskService.GetAll();
        }

        [HttpGet("")]
        public TaskModel? GetById(Guid id)
        {
            return _taskService.GetById(id);
        }

        [HttpDelete("")]
        public bool DeleteById(Guid id)
        {
            return _taskService.DeleteById(id);
        }

        [HttpPut("")]
        public TaskModel? EditByID([FromQuery] Guid id, [FromBody] TaskModel taskModel)
        {
            return _taskService.EditById(id, taskModel);
        }

        [HttpPost("/multi-delete")]
        public bool DeleteByIds([FromBody] List<Guid> guids)
        {
            return _taskService.DeleteByIds(guids);
        }

        [HttpPost("/multi-add")]
        public List<TaskModel> AddMulti([FromBody] List<TaskModelDTO> taskModelDTO)
        {
            return _taskService.AddMulti(taskModelDTO);
        }
    }
}
