using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// The default <see cref="IBinariesDestinationDirectoryName"/> implementation returns "Binaries".
    /// </summary>
    class DefaultBinariesDestinationDirectoryName : IBinariesDestinationDirectoryName
    {
        public string GetBinariesDestinationDirectoryName()
        {
            var binariesDestinationDirectoryName = @"Binaries";
            return binariesDestinationDirectoryName;
        }
    }
}
