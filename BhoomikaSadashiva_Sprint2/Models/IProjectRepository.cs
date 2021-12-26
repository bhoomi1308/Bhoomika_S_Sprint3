using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BhoomikaSadashiva_Sprint2.Models
{
    public interface IProjectRepository
    {
        List<Project> GetAllProjects();
        Project GetProjectById(int id);
        Project AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(int id);
    }
}
