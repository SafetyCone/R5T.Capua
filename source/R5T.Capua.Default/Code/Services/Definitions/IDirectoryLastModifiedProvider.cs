using System;

using R5T.T0064;


namespace R5T.Capua.Default
{
    [ServiceDefinitionMarker]
    public interface IDirectoryLastModifiedProvider : IServiceDefinition
    {
        DateTime GetDirectoryLastModifiedDateTime(string directoryPath);
    }
}
