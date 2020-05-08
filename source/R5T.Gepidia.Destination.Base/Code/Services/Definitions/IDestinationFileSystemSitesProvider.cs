using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.Gepidia.Destination
{
    public interface IDestinationFileSystemSitesProvider
    {
        Task<IEnumerable<FileSystemSite>> GetDestinationFileSystemSitesAsync();
    }
}
