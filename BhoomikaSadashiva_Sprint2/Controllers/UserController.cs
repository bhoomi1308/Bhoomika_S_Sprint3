using BhoomikaSadashiva_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BhoomikaSadashiva_Sprint2.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllUsers();
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var data = _repository.GetUserById(id);
            if (data == null)
                return NotFound("no record found");
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(User user)
        {
            var data = _repository.AddUser(user);
            if (data == null)
                return BadRequest("Oops somethign went wrong, try again");
            return Created(HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + HttpContext.Request.Path + "/" + user.UserId, user);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteUser(id);
            return Ok("record deleted successfully");
        }

        [HttpPut]
        public IActionResult Put(User user)
        {
            _repository.UpdateUser(user);
            return Ok("record updated successfully");
        }
    }
}
