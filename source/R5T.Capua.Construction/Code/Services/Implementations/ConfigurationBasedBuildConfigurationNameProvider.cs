using System;

using Microsoft.Extensions.Options;

using R5T.Palembang;

using R5T.T0064;


namespace R5T.Capua.Construction.Services
{
    [ServiceImplementationMarker]
    class ConfigurationBasedBuildConfigurationNameProvider : IBuildConfigurationNameProvider, IServiceImplementation
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedBuildConfigurationNameProvider(
            IOptions<Configuration.CapuaConfiguration> configuration)
        {
            this.Configuration = configuration;
        }

        public string GetBuildConfigurationName()
        {
            var configuration = this.Configuration.Value;

            var buildConfigurationName = configuration.BuildConfigurationName;
            return buildConfigurationName;
        }
    }
}
