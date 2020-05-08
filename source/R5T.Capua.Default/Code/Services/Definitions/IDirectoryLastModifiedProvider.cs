using System;


namespace R5T.Capua.Default
{
    public interface IDirectoryLastModifiedProvider
    {
        DateTime GetDirectoryLastModifiedDateTime(string directoryPath);
    }
}
