using System;

using Microsoft.Extensions.Options;

using R5T.Capua.Source;


namespace R5T.Capua.Construction.Services
{
    class ConfigurationBasedSolutionDirectoryPathProvider : ISolutionDirectoryPathProvider
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedSolutionDirectoryPathProvider(IOptions<Configuration.CapuaConfiguration> configuration)
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
