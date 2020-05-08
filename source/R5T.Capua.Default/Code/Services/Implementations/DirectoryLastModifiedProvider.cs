using System;
using System.IO;


namespace R5T.Capua.Default
{
    public class DirectoryLastModifiedProvider : IDirectoryLastModifiedProvider
    {
        public DateTime GetDirectoryLastModifiedDateTime(string directoryPath)
        {
            var lastModified = Directory.GetLastWriteTime(directoryPath);
            return lastModified;
        }
    }
}
