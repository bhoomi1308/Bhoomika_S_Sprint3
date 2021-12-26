using BhoomikaSadashiva_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BhoomikaSadashiva_Sprint2.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public string Login(User userModel)
        {
            if (string.IsNullOrEmpty(userModel.EmailId) || string.IsNullOrEmpty(userModel.Password))
            {
                return "UserId and password cannot be null";
            }
            else
            {

                List<User> list = new List<User>();
                list.Add(new User() { UserId = 1, FirstName = "Bhoomika", LastName = "Sadashiva", EmailId = "b@gmail.com", Password = "1234" });
                list.Add(new User() { UserId = 2, FirstName = "Bhoomi", LastName = "Sagara", EmailId = "bs@gmail.com", Password = "12345" });
                var display = list.Where(a => a.UserId == userModel.UserId && a.Password == userModel.Password).FirstOrDefault();
                if (display == null)
                {
                    return "InCorrect UserName and Password";
                }
                return "Correct UserName and Password,Welcome";
            }
        }
    }
}
