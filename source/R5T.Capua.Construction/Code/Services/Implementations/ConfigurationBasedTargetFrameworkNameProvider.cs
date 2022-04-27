using System;

using Microsoft.Extensions.Options;

using R5T.Palembang;

using R5T.T0064;


namespace R5T.Capua.Construction.Services
{
    [ServiceImplementationMarker]
    class ConfigurationBasedTargetFrameworkNameProvider : ITargetFrameworkNameProvider,
        IServiceImplementation
    {
        private IOptions<Configuration.CapuaConfiguration> Configuration { get; }


        public ConfigurationBasedTargetFrameworkNameProvider(
            IOptions<Configuration.CapuaConfiguration> configuration)
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
