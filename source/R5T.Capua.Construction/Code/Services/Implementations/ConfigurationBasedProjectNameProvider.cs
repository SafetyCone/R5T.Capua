using System;

using Microsoft.Extensions.Options;

using R5T.Capua.Common;


namespace R5T.Capua.Construction.Services
{
    class ConfigurationBasedProjectNameProvider : IProjectNameProvider
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedProjectNameProvider(IOptions<Configuration.CapuaConfiguration> configuration)
        {
            this.Configuration = configuration;
        }

        public string GetProjectName()
        {
            var configuration = this.Configuration.Value;

            var projectName = configuration.ProjectName;
            return projectName;
        }
    }
}
