using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Capua
{
    [ServiceDefinitionMarker]
    public interface IDeployBuiltBinariesAction : IServiceDefinition
    {
        Task RunAsync();
    }
}
