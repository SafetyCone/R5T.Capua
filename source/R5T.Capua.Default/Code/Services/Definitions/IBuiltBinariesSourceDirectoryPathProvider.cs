using System;
using System.Threading.Tasks;


namespace R5T.Capua.Default
{
    public interface IBuiltBinariesSourceDirectoryPathProvider
    {
        Task<string> GetBuiltBinariesSourceDirectoryPath();
    }
}
