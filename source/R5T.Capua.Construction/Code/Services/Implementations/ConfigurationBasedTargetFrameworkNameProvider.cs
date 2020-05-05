using System;

using Microsoft.Extensions.Options;

using R5T.Capua.Source;
using R5T.Palembang;


namespace R5T.Capua.Construction.Services
{
    class ConfigurationBasedTargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedTargetFrameworkNameProvider(IOptions<Configuration.CapuaConfiguration> configuration)
        {
            this.Configuration = configuration;
        }

        public string GetTargetFrameworkName()
        {
            var configuration = this.Configuration.Value;

            var targetFrameworkName = configuration.TargetFrameworkName;
            return targetFrameworkName;
        }
    }
}
