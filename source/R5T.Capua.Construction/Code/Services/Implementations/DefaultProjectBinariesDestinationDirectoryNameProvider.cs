using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// The default <see cref="IProjectBinariesDestinationDirectoryNameProvider"/> implementation uses the <see cref="IProjectDirectoryNameProvider"/> service and assumes that the two directory names are the same.
    /// </summary>
    class DefaultProjectBinariesDestinationDirectoryNameProvider : IProjectBinariesDestinationDirectoryNameProvider
    {
        private IProjectDirectoryNameProvider ProjectDirectoryNameProvider { get; }


        public DefaultProjectBinariesDestinationDirectoryNameProvider(IProjectDirectoryNameProvider projectDirectoryNameProvider)
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
