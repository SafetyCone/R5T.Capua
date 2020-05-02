using System;


namespace R5T.Capua.Construction.Services
{
    public class CommandLineArgumentsProvider : ICommandLineArgumentsProvider
    {
        public string[] GetCommandLineArguments()
        {
            var args = Environment.GetCommandLineArgs();
            return args;
        }
    }
}
