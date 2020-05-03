using System;

using R5T.Capua.Common;


namespace R5T.Capua.Source.Default
{
    /// <summary>
    /// The default <see cref="IProjectDirectoryNameProvider"/> implementation using the <see cref="IProjectNameProvider"/> service and presumes that the project directory name is the same as the project name.
    /// </summary>
    public class ProjectDirectoryNameProvider : IProjectDirectoryNameProvider
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
