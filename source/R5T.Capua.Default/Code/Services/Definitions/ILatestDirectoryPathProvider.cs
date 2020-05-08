using System;
using System.Threading.Tasks;


namespace R5T.Capua.Default
{
    /// <summary>
    /// Provides the directory path for the the directory that will contain the latest build of binaries.
    /// </summary>
    public interface ILatestDirectoryPathProvider
    {
        Task<string> GetLatestDirectoryPath();
    }
}
