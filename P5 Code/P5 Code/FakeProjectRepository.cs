using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public class FakeProjectRepository : IProjectRepository
    {
        // Error Strings. These are returned as error codes. The
        const string NO_ERROR = "";
        const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project id.";
        const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        const string NO_PROJECT_FOUND_ERROR = "No project found.";
        const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        private static List<Project> Projects;

        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new List<Project>();

                Projects.Add(new Project // req 6a
                {
                    Id = GetNextId(),
                    Name = "Sample Project Id0",
                });
            }
        }
        public string Add(Project project, int outId)//idk what this outId is for. referenced in UML diagram.
        {
            project.Name = project.Name.Trim(); //req 6c
            if (project.Name != "") // req 6d
            {
                if (!IsDuplicateName(project.Name)) //req 6f
                {
                    Projects.Add(project);
                    return NO_ERROR;
                }
                else
                {
                    return DUPLICATE_PROJECT_NAME_ERROR;
                }
            }
            else
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            
        }
        public string Remove(int projectId)
        {
            Project projectToDelete = null;

            foreach(Project project in Projects) //locates the target project.
            {
                if (project.Id == projectId)
                {
                    projectToDelete = project;
                }
            }

            throw new NotImplementedException();
            // Not sure if these go here.
            if(projectToDelete == null) // checks to ensure it exists, or throws error.
            {
                return NO_PROJECT_FOUND_ERROR;
            }

            if (!true/*projectToDelete.Id == preference */)
            {
                return "Cannot remove your current session project."; // i think this condition needs access to FakePrefenceRepo, which i haven't done yet.
            }

            Projects.Remove(projectToDelete);
            return NO_ERROR;
        }
        public string Modify(int projectId, Project project)
        {
            throw new NotImplementedException();//-----------------------------------------------------------------------------------------------------------------!!
        }
        public List<Project> GetAll()
        {
            return Projects; // return project list.
        }
        public bool IsDuplicateName(string projectName)
        {
            foreach(Project project in Projects)
            {
                if(project.Name == projectName)
                { //if the projectName is equal to any of the previous projects, return true.
                    return true;
                }
            }
            return false;
        }
        private int GetNextId()
        {
            int largestId = 0;

            if (Projects == null)
            {
                return 0;
            }
            foreach(Project p in Projects)
            {
                if(p.Id > largestId)
                {
                    largestId = p.Id;
                }
            }

            return largestId+1;
        }
    }
}
