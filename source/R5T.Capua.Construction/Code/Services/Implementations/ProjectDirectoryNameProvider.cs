using System;


namespace R5T.Capua.Construction.Services
{
    class ProjectDirectoryNameProvider : IProjectDirectoryNameProvider
    {
        private IProjectNameProvider ProjectNameProvider { get; }


        public ProjectDirectoryNameProvider(IProjectNameProvider projectNameProvider)
        {
            this.ProjectNameProvider = projectNameProvider;
        }

        public string GetProjectDirectoryName()
        {
            var projectName = this.ProjectNameProvider.GetProjectName();

            var projectDirectoryName = projectName; // Presume the project directory name is the same as the project name.
            return projectDirectoryName;
        }
    }
}
