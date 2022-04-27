using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Capua.Default
{
    [ServiceDefinitionMarker]
    public interface IBuiltBinariesSourceDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetBuiltBinariesSourceDirectoryPath();
    }
}
