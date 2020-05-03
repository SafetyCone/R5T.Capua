using System;
using System.Threading.Tasks;


namespace R5T.Gepidia.Source
{
    public interface ISourceFileSystemSiteProvider
    {
        Task<FileSystemSite> GetSourceFileSystemSiteAsync();
    }
}
