using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.Capua.Source;
using R5T.Capua.Source.Default;


namespace R5T.Capua.Construction.Services
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultBuildOutputDirectoryNameProvider"/> implementation of <see cref="IBuildOutputDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultBuildOutputDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IBuildOutputDirectoryNameProvider, BuildOutputDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultBuildOutputDirectoryNameProvider"/> implementation of <see cref="IBuildOutputDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultBuildOutputDirectoryNameProvider<TBuildOutputDirectoryNameProvider>(this IServiceCollection services)
            where TBuildOutputDirectoryNameProvider: IBuildOutputDirectoryNameProvider
        {
            services.AddDefaultBuildOutputDirectoryNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultBuildOutputDirectoryNameProvider"/> implementation of <see cref="IBuildOutputDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IBuildOutputDirectoryNameProvider> AddDefaultBuildOutputDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IBuildOutputDirectoryNameProvider>(() => services.AddDefaultBuildOutputDirectoryNameProvider());
            return serviceAction;
        }
    }
}
