using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// The default <see cref="IProjectDirectoryNameProvider"/> implementation using the <see cref="IProjectNameProvider"/> service and presumes that the project directory name is the same as the project name.
    /// </summary>
    public class DefaultProjectDirectoryNameProvider : IProjectDirectoryNameProvider
    {
        private IProjectNameProvider ProjectNameProvider { get; }


        public DefaultProjectDirectoryNameProvider(IProjectNameProvider projectNameProvider)
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
