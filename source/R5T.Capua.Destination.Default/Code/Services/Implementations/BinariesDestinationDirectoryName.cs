using System;using R5T.T0064;


namespace R5T.Capua.Destination.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// The default <see cref="IBinariesDestinationDirectoryName"/> implementation returns "Binaries".
    /// </summary>
    public class BinariesDestinationDirectoryName : IBinariesDestinationDirectoryName,IServiceImplementation
    {
        public string GetBinariesDestinationDirectoryName()
        {
            var binariesDestinationDirectoryName = @"Binaries";
            return binariesDestinationDirectoryName;
        }
    }
}
