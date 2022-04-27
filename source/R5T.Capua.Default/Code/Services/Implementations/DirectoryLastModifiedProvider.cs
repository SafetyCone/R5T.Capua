using System;
using System.IO;

using R5T.T0064;


namespace R5T.Capua.Default
{
    [ServiceImplementationMarker]
    public class DirectoryLastModifiedProvider : IDirectoryLastModifiedProvider, IServiceImplementation
    {
        public DateTime GetDirectoryLastModifiedDateTime(string directoryPath)
        {
            var lastModified = Directory.GetLastWriteTime(directoryPath);
            return lastModified;
        }
    }
}
