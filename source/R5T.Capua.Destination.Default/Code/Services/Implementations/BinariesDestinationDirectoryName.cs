using System;


namespace R5T.Capua.Destination.Default
{
    /// <summary>
    /// The default <see cref="IBinariesDestinationDirectoryName"/> implementation returns "Binaries".
    /// </summary>
    public class BinariesDestinationDirectoryName : IBinariesDestinationDirectoryName
    {
        public string GetBinariesDestinationDirectoryName()
        {
            var binariesDestinationDirectoryName = @"Binaries";
            return binariesDestinationDirectoryName;
        }
    }
}
