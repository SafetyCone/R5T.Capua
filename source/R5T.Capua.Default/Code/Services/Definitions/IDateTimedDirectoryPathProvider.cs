using System;
using System.Threading.Tasks;


namespace R5T.Capua.Default
{
    public interface IDateTimedDirectoryPathProvider
    {
        Task<string> GetDateTimedDirectoryPathAsync();
    }
}
