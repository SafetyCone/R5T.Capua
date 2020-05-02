using System;


namespace R5T.Capua.Construction.Services
{
    class ProjectNameProvider : IProjectNameProvider
    {
        public string GetProjectName()
        {
            var projectName = "R5T.Capua";
            return projectName;
        }
    }
}
