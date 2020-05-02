using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Alamania;
using R5T.Alamania.Standard;
using R5T.Dacia;
using R5T.Gepidia.Local;
using R5T.Lombardy;
using R5T.Richmond;
using R5T.Sardinia;
using R5T.Shrewsbury.Extensions;
using R5T.Teutonia;
using R5T.Teutonia.Standard;


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
                .AddSingleton<IBinariesDestinationDirectoryName, DefaultBinariesDestinationDirectoryName>()
                .AddDefaultBuildOutputDirectoryNameProvider<IBuildOutputDirectoryNameProvider>()
                .AddSingleton<IBuildConfigurationNameProvider, DebugBuildConfigurationNameProvider>()
                .AddSingleton<IBuildConfigurationDirectoryNameProvider, DefaultBuildConfigurationDirectoryNameProvider>()
                .AddSingleton<IDestinationFileSystemSiteProvider, DestinationFileSystemSiteProvider>()
                .AddFileSystemCloningOperator<IFileSystemCloningOperator>()
                .AddLocalFileSystemOperator<ILocalFileSystemOperator>(ServiceAction<IStringlyTypedPathOperator>.AddedElsewhere)
                .AddSingleton<IProjectBinariesDestinationDirectoryNameProvider, DefaultProjectBinariesDestinationDirectoryNameProvider>()
                .AddSingleton<IProjectNameProvider, ConfigurationBasedProjectNameProvider>()
                .AddSingleton<IProjectDirectoryNameProvider, DefaultProjectDirectoryNameProvider>()
                .AddRivetOrganizationDirectoryPathProvider<IRivetOrganizationDirectoryPathProvider>()
                .AddSingleton<ISolutionDirectoryPathProvider, ConfigurationBasedSolutionDirectoryPathProvider>()
                .AddSingleton<ISourceFileSystemSiteProvider, SourceFileSystemSiteProvider>()
                .AddDefaultStringlyTypedPathOperator<IStringlyTypedPathOperator>()
                .AddSingleton<ITargetFrameworkDirectoryNameProvider, DefaultTargetFrameworkDirectoryNameProvider>()
                .AddSingleton<ITargetFrameworkNameProvider, NetStandard20TargetFrameworkNameProvider>()
                ;
        }
    }
}
