using BhoomikaSadashiva_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BhoomikaSadashiva_Sprint2.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository _repository;
        public TaskController(ITaskRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllTasks();
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var data = _repository.GetTasksById(id);
            if (data == null)
                return NotFound("no record found");
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(TaskModel taskModel)
        {
            var data = _repository.AddTasks(taskModel);
            if (data == null)
                return BadRequest("Oops somethign went wrong, try again");
            return Created(HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + HttpContext.Request.Path + "/" + taskModel.ProjectId, taskModel);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteTasks(id);
            return Ok("record deleted successfully");
        }

        [HttpPut]
        public IActionResult Put(TaskModel taskModel)
        {
            _repository.UpdateTasks(taskModel);
            return Ok("record updated successfully");
        }
    }
}
