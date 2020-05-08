using System;
using System.Threading.Tasks;


namespace R5T.Capua.Default
{
    public interface IDateTimedDirectoryNameProvider
    {
        Task<string> GetDateTimedDirectoryNameAsync();
    }
}
