using System;


namespace R5T.Capua.Construction.Services
{
    class BinariesDestinationDirectoryName : IBinariesDestinationDirectoryName
    {
        public string GetBinariesDestinationDirectoryName()
        {
            var binariesDestinationDirectoryName = @"Binaries";
            return binariesDestinationDirectoryName;
        }
    }
}
