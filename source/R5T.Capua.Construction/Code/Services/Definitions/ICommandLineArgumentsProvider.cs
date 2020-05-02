using System;


namespace R5T.Capua.Construction.Services
{
    public interface ICommandLineArgumentsProvider
    {
        string[] GetCommandLineArguments();
    }
}
