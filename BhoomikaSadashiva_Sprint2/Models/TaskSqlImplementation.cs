using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BhoomikaSadashiva_Sprint2.Models
{
    public class TaskSqlImplementation:ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskSqlImplementation(AppDbContext context)
        {
            _context = context;
        }

        public TaskModel AddTasks(TaskModel taskModel)
        {
            _context.TaskModel.Add(taskModel);
            _context.SaveChanges();
            return taskModel;
        }

        public void DeleteTasks(int id)
        {
            TaskModel taskModel = GetTasksById(id);
            _context.TaskModel.Remove(taskModel);
            _context.SaveChanges();
        }

        public List<TaskModel> GetAllTasks()
        {
            return _context.TaskModel.ToList();
        }

        public TaskModel GetTasksById(int id)
        {
            return _context.TaskModel.FirstOrDefault(user => user.TaskId == id);
        }

        public void UpdateTasks(TaskModel taskModel)
        {
            var data = new TaskModel()
            {
                TaskId = taskModel.TaskId,
                AssignedUserId = taskModel.AssignedUserId,
                Status = taskModel.Status,
                CreatedOn = taskModel.CreatedOn
            };
        }
    }
}
