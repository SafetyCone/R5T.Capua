using System;
using System.Threading.Tasks;


namespace R5T.Gepidia.Destination
{
    public interface IDestinationFileSystemSiteProvider
    {
        Task<FileSystemSite> GetDestinationFileSystemSiteAsync();
    }
}
