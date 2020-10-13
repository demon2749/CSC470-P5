using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{// NOT SURE IF THIS IS RIGHT, WILL REVIST AFTER CLASS ---------------------------------------------
    public class FakeProjectRepository : IProjectRepository
    {
        public static List<Project> Projects;

        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new List<Project>();

                Projects.Add(new Project
                {
                    Id = 0,
                    Name = "Sample Project Id0"
                });
            }
        }
        public string Add(Project project, int outId)
        {

        }
        public string Remove(int projectId)
        {

        }
        public string Modify(int projectId, Project project)
        {

        }
        public List<Project> GetAll()
        {

        }
        public bool IsDuplicateName(string projectName)
        {

        }
    }
}
