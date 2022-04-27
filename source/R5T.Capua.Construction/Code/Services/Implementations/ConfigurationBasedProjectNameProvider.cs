using System;

using Microsoft.Extensions.Options;

using R5T.Palembang;

using R5T.T0064;


namespace R5T.Capua.Construction.Services
{
    [ServiceImplementationMarker]
    class ConfigurationBasedProjectNameProvider : IProjectNameProvider, IServiceImplementation
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedProjectNameProvider(
            IOptions<Configuration.CapuaConfiguration> configuration)
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
