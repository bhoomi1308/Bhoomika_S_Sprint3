using BhoomikaSadashiva_Sprint2.Controllers;
using BhoomikaSadashiva_Sprint2.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Test_Sprint3_Bhoomika_Sadashiva
{
    class TaskControllerTest
    {
        private readonly ITaskRepository _repository;

        public TaskControllerTest(ITaskRepository repository)
        {
            _repository = repository;
        }
        [Fact]
        public void GetTaskID_Return_OkResult()
        {
            int id = 2;
            //Arrange
            TaskController controller = new TaskController(_repository);

            //Act
            var data = controller.Get(id);

            var expectedResult = controller.Get(2);
            //Assert
            Assert.Equal(expectedResult, data);

        }
        [Fact]
        public void GetTaskID_Return_NotFound()
        {
            int id = 2;
            //Arrange
            TaskController controller = new TaskController(_repository);

            //Act
            var data = controller.Get(id);

            controller.Get(2);
            //Assert
            Assert.IsType<NotFoundResult>(data);

        }

        [Fact]
        public void GetAllTask_Return_OKResult()
        {
            //Arrange
            var controller = new TaskController(_repository);

            //Act
            var data = controller.Get();

            //Assert
            Assert.IsType<OkObjectResult>(data);

        }

        [Fact]
        public void GetAllTask_Return_NotFound()
        {
            //Arrange
            var controller = new TaskController(_repository);

            //Act
            var data = controller.Get();

            //Assert
            Assert.IsType<NotFoundResult>(data);

        }


        [Fact]
        public void Delete_Task_Return_Ok()
        {
            int id = 2;
            //Arrange
            var controller = new TaskController(_repository);

            //Act
            var data = controller.Delete(id);

            //Assert
            Assert.IsType<OkObjectResult>(data);

        }

        [Fact]
        public void Delete_Task_Return_NotFound()
        {
            int id = 2;
            //Arrange
            var controller = new TaskController(_repository);

            //Act
            var data = controller.Delete(id);

            //Assert
            Assert.IsType<NotFoundResult>(data);

        }
    }
}
