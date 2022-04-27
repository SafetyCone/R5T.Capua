using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Capua.Default
{
    /// <summary>
    /// Provides the directory path for the the directory that will contain the latest build of binaries.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ILatestDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetLatestDirectoryPath();
    }
}
