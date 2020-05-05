using System;

using Microsoft.Extensions.Options;

using R5T.Palembang;


namespace R5T.Capua.Construction.Services
{
    class ConfigurationBasedBuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedBuildConfigurationNameProvider(IOptions<Configuration.CapuaConfiguration> configuration)
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
