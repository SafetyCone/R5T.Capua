using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// The default <see cref="ICommandLineArgumentsProvider"/> implementation.
    /// </summary>
    public class DefaultCommandLineArgumentsProvider : ICommandLineArgumentsProvider
    {
        public string[] GetCommandLineArguments()
        {
            var args = Environment.GetCommandLineArgs();
            return args;
        }
    }
}
