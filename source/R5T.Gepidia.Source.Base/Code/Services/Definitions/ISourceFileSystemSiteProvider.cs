using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.Gepidia.Source
{[ServiceDefinitionMarker]
    public interface ISourceFileSystemSiteProvider:IServiceDefinition
    {
        Task<FileSystemSite> GetSourceFileSystemSiteAsync();
    }
}
