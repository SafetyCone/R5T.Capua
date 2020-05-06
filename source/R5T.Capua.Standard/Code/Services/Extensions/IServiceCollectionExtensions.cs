using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Alamania;
using R5T.Alamania.Standard;
using R5T.Dacia;
using R5T.Gepidia.Destination;
using R5T.Gepidia.Local;
using R5T.Gepidia.Source;
using R5T.Lombardy;
using R5T.Teutonia;
using R5T.Teutonia.Standard;

using R5T.Capua.Destination;
using R5T.Capua.Destination.Default;
using R5T.Capua.Default;
using R5T.Capua.Teutonia;
using R5T.Palembang;
using R5T.Ujung;
using R5T.Ujung.Default;
using R5T.Ujung.Palembang;


namespace R5T.Capua.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDeployBuiltBinariesAction(this IServiceCollection services,
            ServiceAction<IBuildConfigurationNameProvider> addBuildConfigurationNameProvider,
            ServiceAction<IProjectNameProvider> addProjectNameProviderAction,
            ServiceAction<ISolutionDirectoryPathProvider> addSolutionDirectoryPathProviderAction,
            ServiceAction<ITargetFrameworkNameProvider> addTargetFrameworkNameProviderAction)
        {
            services
                .RunServiceAction(addBuildConfigurationNameProvider)
                .RunServiceAction(addProjectNameProviderAction)
                .RunServiceAction(addSolutionDirectoryPathProviderAction)
                .RunServiceAction(addTargetFrameworkNameProviderAction)
                ;

            services
                .AddSingleton<IBinariesDestinationDirectoryName, BinariesDestinationDirectoryName>()
                .AddDefaultBuildOutputDirectoryNameProvider<IBuildOutputDirectoryNameProvider>()
                .AddSingleton<IBuildConfigurationDirectoryNameProvider, BuildConfigurationDirectoryNameProvider>()
                .AddSingleton<IDeployBuiltBinariesAction, DeployBuiltBinariesAction>()
                .AddSingleton<IDestinationFileSystemSiteProvider, RivetOrganizationDirectoryDestinationFileSystemSiteProvider>()
                .AddFileSystemCloningOperator<IFileSystemCloningOperator>()
                .AddLocalFileSystemOperator<ILocalFileSystemOperator>(ServiceAction<IStringlyTypedPathOperator>.AddedElsewhere)
                .AddSingleton<IProjectBinariesDestinationDirectoryNameProvider, ProjectBinariesDestinationDirectoryNameProvider>()
                .AddSingleton<IProjectDirectoryNameProvider, ProjectDirectoryNameProvider>()
                .AddRivetOrganizationDirectoryPathProvider<IRivetOrganizationDirectoryPathProvider>()
                .AddSingleton<ISourceFileSystemSiteProvider, BuiltBinariesSourceFileSystemSiteProvider>()
                .AddDefaultStringlyTypedPathOperator<IStringlyTypedPathOperator>()
                .AddSingleton<ITargetFrameworkDirectoryNameProvider, TargetFrameworkDirectoryNameProvider>()
                ;

            return services;
        }

        public static IServiceCollection AddDeployBuiltBinariesAction<TDeployBuiltBinariesAction>(this IServiceCollection services,
            ServiceAction<IBuildConfigurationNameProvider> addBuildConfigurationNameProvider,
            ServiceAction<IProjectNameProvider> addProjectNameProviderAction,
            ServiceAction<ISolutionDirectoryPathProvider> addSolutionDirectoryPathProviderAction,
            ServiceAction<ITargetFrameworkNameProvider> addTargetFrameworkNameProviderAction)
            where TDeployBuiltBinariesAction: IDeployBuiltBinariesAction
        {
            services.AddDeployBuiltBinariesAction(
                addBuildConfigurationNameProvider,
                addProjectNameProviderAction,
                addSolutionDirectoryPathProviderAction,
                addTargetFrameworkNameProviderAction
                );

            return services;
        }
    }
}
