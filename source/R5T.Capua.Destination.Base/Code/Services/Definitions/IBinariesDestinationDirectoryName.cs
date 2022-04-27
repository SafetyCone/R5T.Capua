﻿using System;

using R5T.T0064;


namespace R5T.Capua.Destination
{
    [ServiceDefinitionMarker]
    public interface IBinariesDestinationDirectoryName : IServiceDefinition
    {
        string GetBinariesDestinationDirectoryName();
    }
}
