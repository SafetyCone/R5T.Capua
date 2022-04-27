using System;

using Microsoft.Extensions.Options;

using R5T.Ujung;

using R5T.T0064;


namespace R5T.Capua.Construction.Services
{
    [ServiceImplementationMarker]
    class ConfigurationBasedSolutionDirectoryPathProvider : ISolutionDirectoryPathProvider, IServiceImplementation
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedSolutionDirectoryPathProvider(
            IOptions<Configuration.CapuaConfiguration> configuration)
        {
            this.Configuration = configuration;
        }

        public string GetSolutionDirectoryPath()
        {
            var configuration = this.Configuration.Value;

            var solutionDirectoryPath = configuration.SolutionDirectoryPath;
            return solutionDirectoryPath;
        }
    }
}
