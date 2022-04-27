using System;
using System.Collections.Generic;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.Gepidia.Destination
{[ServiceDefinitionMarker]
    public interface IDestinationFileSystemSitesProvider:IServiceDefinition
    {
        Task<IEnumerable<FileSystemSite>> GetDestinationFileSystemSitesAsync();
    }
}
