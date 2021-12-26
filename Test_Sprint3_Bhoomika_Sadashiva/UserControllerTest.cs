using BhoomikaSadashiva_Sprint2.Controllers;
using BhoomikaSadashiva_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Test_Sprint3_Bhoomika_Sadashiva
{
    class UserControllerTest
    {
        private readonly IUserRepository _repository;

        public UserControllerTest(IUserRepository repository)
        {
            _repository = repository;
        }
        [Fact]
        public void GetUserID_Return_OkResult()
        {
            int id = 2;
            //Arrange
            UserController controller = new UserController(_repository);

            //Act
            var data = controller.Get(id);

            var expectedResult = controller.Get(2);
            //Assert
            Assert.Equal(expectedResult, data);

        }

        [Fact]
        public void GetUserID_Return_NotFound()
        {
            int id = 2;
            //Arrange
            UserController controller = new UserController(_repository);

            //Act
            var data = controller.Get(id);

            controller.Get(2);
            //Assert
            Assert.IsType<NotFoundResult>(data);

        }

        [Fact]
        public void GetAllUsers_Return_OKResult()
        {
            //Arrange
            var controller = new UserController(_repository);

            //Act
            var data = controller.Get();

            //Assert
            Assert.IsType<OkObjectResult>(data);

        }

        [Fact]
        public void Delete_User_Return_Ok()
        {
            int id = 2;
            //Arrange
            var controller = new UserController(_repository);

            //Act
            var data = controller.Delete(id);

            //Assert
            Assert.IsType<OkObjectResult>(data);

        }

        [Fact]
        public void Delete_User_Return_NotFound()
        {
            int id = 2;
            //Arrange
            var controller = new UserController(_repository);

            //Act
            var data = controller.Delete(id);

            //Assert
            Assert.IsType<NotFoundResult>(data);

        }
    }
}
