using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BhoomikaSadashiva_Sprint2.Models
{
    public class ProjectSqlImplementation:IProjectRepository
    {
        private readonly AppDbContext _context;
        private int count = 2;

        public ProjectSqlImplementation(AppDbContext context)
        {
            _context = context;
        }

        public Project AddProject(Project project)
        {
            _context.Project.Add(project);
            _context.SaveChanges();
            return project;
        }

        public void DeleteProject(int id)
        {
            Project project = GetProjectById(id);
            _context.Project.Remove(project);
            _context.SaveChanges();
        }

        public List<Project> GetAllProjects()
        {
            return _context.Project.ToList();
        }

        public Project GetProjectById(int id)
        {
            return _context.Project.FirstOrDefault(user => user.ProjectId == id);
        }

        public void UpdateProject(Project project)
        {
            var data = new Project()
            {
                ProjectId = ++count,
                Name = project.Name,
                CreatedOn = DateTime.Now
            };
        }
    }
}
