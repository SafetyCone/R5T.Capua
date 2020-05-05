using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Dacia;
using R5T.Richmond;
using R5T.Sardinia;
using R5T.Shrewsbury.Extensions;

using R5T.Capua.Common;
using R5T.Capua.Source;
using R5T.Capua.Standard;
using R5T.Palembang;

using R5T.Capua.Construction.Services;


namespace R5T.Capua.Construction
{
    class Startup : StartupBase
    {
        public Startup(ILogger<StartupBase> logger)
            : base(logger)
        {
        }

        protected override void ConfigureConfigurationBody(IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder
                .AddDefaultAppSettingsJsonFile()
                ;
        }

        protected override void ConfigureServicesBody(IServiceCollection services)
        {
            services
                .AddOptions()
                .Configure<Configuration.Raw.CapuaConfiguration>()
                .ConfigureOptions<Configuration.CapuaConfigurationConfigureOptions>()
                ;

            services
                .AddDeployBuiltBinariesAction(
                    new ServiceAction<IBuildConfigurationNameProvider>(() => services.AddSingleton<IBuildConfigurationNameProvider, ConfigurationBasedBuildConfigurationNameProvider>()),
                    new ServiceAction<IProjectNameProvider>(() => services.AddSingleton<IProjectNameProvider, ConfigurationBasedProjectNameProvider>()),
                    new ServiceAction<ISolutionDirectoryPathProvider>(() => services.AddSingleton<ISolutionDirectoryPathProvider, ConfigurationBasedSolutionDirectoryPathProvider>()),
                    new ServiceAction<ITargetFrameworkNameProvider>(() => services.AddSingleton<ITargetFrameworkNameProvider, ConfigurationBasedTargetFrameworkNameProvider>())
                    );
        }
    }
}
