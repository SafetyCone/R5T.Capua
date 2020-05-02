using System;

using Microsoft.Extensions.Options;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Lombardy;


namespace R5T.Capua.Construction.Services
{
    class SourceFileSystemSiteProvider : ISourceFileSystemSiteProvider
    {
        private IBuildOutputDirectoryNameProvider BuildOutputDirectoryNameProvider { get; }
        private IBuildConfigurationDirectoryNameProvider BuildConfigurationDirectoryNameProvider { get; }
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }
        private IProjectDirectoryNameProvider ProjectDirectoryNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }
        private ISolutionDirectoryPathProvider SolutionDirectoryPathProvider { get; }
        private ITargetFrameworkDirectoryNameProvider TargetFrameworkDirectoryNameProvider { get; }


        public SourceFileSystemSiteProvider(
            IBuildOutputDirectoryNameProvider buildOutputDirectoryNameProvider,
            IBuildConfigurationDirectoryNameProvider buildConfigurationDirectoryNameProvider,
            ILocalFileSystemOperator localFileSystemOperator,
            IProjectDirectoryNameProvider projectDirectoryNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator,
            ISolutionDirectoryPathProvider solutionDirectoryPathProvider,
            ITargetFrameworkDirectoryNameProvider targetFrameworkDirectoryNameProvider)
        {
            this.BuildOutputDirectoryNameProvider = buildOutputDirectoryNameProvider;
            this.BuildConfigurationDirectoryNameProvider = buildConfigurationDirectoryNameProvider;
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.ProjectDirectoryNameProvider = projectDirectoryNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
            this.SolutionDirectoryPathProvider = solutionDirectoryPathProvider;
            this.TargetFrameworkDirectoryNameProvider = targetFrameworkDirectoryNameProvider;
        }

        public FileSystemSite GetSourceFileSystemSite()
        {
            var solutionDirectoryPath = this.SolutionDirectoryPathProvider.GetSolutionDirectoryPath();
            var projectDirectoryName = this.ProjectDirectoryNameProvider.GetProjectDirectoryName();
            var buildOutputDirectoryName = this.BuildOutputDirectoryNameProvider.GetBuildOutputDirectoryName();
            var buildConfigurationDirectoryName = this.BuildConfigurationDirectoryNameProvider.GetBuildConfigurationDirectoryName();
            var targetFrameworkDirectoryName = this.TargetFrameworkDirectoryNameProvider.GetTargetFrameworkDirectoryName();

            var sourceDirectoryPath = this.StringlyTypedPathOperator.Combine(
                solutionDirectoryPath,
                projectDirectoryName,
                buildOutputDirectoryName,
                buildConfigurationDirectoryName,
                targetFrameworkDirectoryName);

            var output = FileSystemSite.New(sourceDirectoryPath, this.LocalFileSystemOperator);
            return output;
        }
    }
}
