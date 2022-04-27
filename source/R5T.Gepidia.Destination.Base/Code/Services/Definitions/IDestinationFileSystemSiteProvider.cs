using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.Gepidia.Destination
{[ServiceDefinitionMarker]
    public interface IDestinationFileSystemSiteProvider:IServiceDefinition
    {
        Task<FileSystemSite> GetDestinationFileSystemSiteAsync();
    }
}
