using System;


namespace R5T.Capua.Construction.Services
{
    class ProjectBinariesDestinationDirectoryNameProvider : IProjectBinariesDestinationDirectoryNameProvider
    {
        public string GetProjectBinariesDestinationDirectoryName()
        {
            var projectBinariesDestinationDirectoryName = "Capua";
            return projectBinariesDestinationDirectoryName;
        }
    }
}
