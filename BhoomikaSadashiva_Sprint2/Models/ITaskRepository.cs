using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BhoomikaSadashiva_Sprint2.Models
{
    public interface ITaskRepository
    {
        List<TaskModel> GetAllTasks();
        TaskModel GetTasksById(int id);
        TaskModel AddTasks(TaskModel taskModel);
        void UpdateTasks(TaskModel taskModel);
        void DeleteTasks(int id);
    }
}
