using System;

using R5T.Capua.Common;


namespace R5T.Capua.Destination.Default
{
    /// <summary>
    /// The default <see cref="IProjectBinariesDestinationDirectoryNameProvider"/> implementation uses the <see cref="IProjectDirectoryNameProvider"/> service and assumes that the two directory names are the same.
    /// </summary>
    public class ProjectBinariesDestinationDirectoryNameProvider : IProjectBinariesDestinationDirectoryNameProvider
    {
        private IProjectDirectoryNameProvider ProjectDirectoryNameProvider { get; }


        public ProjectBinariesDestinationDirectoryNameProvider(IProjectDirectoryNameProvider projectDirectoryNameProvider)
        {
            this.ProjectDirectoryNameProvider = projectDirectoryNameProvider;
        }

        public string GetProjectBinariesDestinationDirectoryName()
        {
            var projectDirectoryName = this.ProjectDirectoryNameProvider.GetProjectDirectoryName();

            var projectBinariesDestinationDirectoryName = projectDirectoryName; // Assume that the two directory names are the same.
            return projectBinariesDestinationDirectoryName;
        }
    }
}
