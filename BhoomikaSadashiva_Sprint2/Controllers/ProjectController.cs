using BhoomikaSadashiva_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BhoomikaSadashiva_Sprint2.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _repository;

        public ProjectController(IProjectRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllProjects();
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var data = _repository.GetProjectById(id);
            if (data == null)
                return NotFound("no record found");
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(Project project)
        {
            var data = _repository.AddProject(project);
            if (data == null)
                return BadRequest("Oops somethign went wrong, try again");
            return Created(HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + HttpContext.Request.Path + "/" + project.ProjectId, project);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteProject(id);
            return Ok("record deleted successfully");
        }

        [HttpPut]
        public IActionResult Put(Project project)
        {
            _repository.UpdateProject(project);
            return Ok("record updated successfully");
        }
    }
}
