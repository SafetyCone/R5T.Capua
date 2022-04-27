using System;
using System.Threading.Tasks;

using R5T.Lombardy;
using R5T.Ujung;

using R5T.T0064;


namespace R5T.Capua.Default
{
    [ServiceImplementationMarker]
    public class BuiltBinariesSourceDirectoryPathProvider : IBuiltBinariesSourceDirectoryPathProvider, IServiceImplementation
    {
        private IBuildOutputDirectoryNameProvider BuildOutputDirectoryNameProvider { get; }
        private IBuildConfigurationDirectoryNameProvider BuildConfigurationDirectoryNameProvider { get; }
        private IProjectDirectoryNameProvider ProjectDirectoryNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }
        private ISolutionDirectoryPathProvider SolutionDirectoryPathProvider { get; }
        private ITargetFrameworkDirectoryNameProvider TargetFrameworkDirectoryNameProvider { get; }


        public BuiltBinariesSourceDirectoryPathProvider(
            IBuildOutputDirectoryNameProvider buildOutputDirectoryNameProvider,
            IBuildConfigurationDirectoryNameProvider buildConfigurationDirectoryNameProvider,
            IProjectDirectoryNameProvider projectDirectoryNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator,
            ISolutionDirectoryPathProvider solutionDirectoryPathProvider,
            ITargetFrameworkDirectoryNameProvider targetFrameworkDirectoryNameProvider)
        {
            this.BuildOutputDirectoryNameProvider = buildOutputDirectoryNameProvider;
            this.BuildConfigurationDirectoryNameProvider = buildConfigurationDirectoryNameProvider;
            this.ProjectDirectoryNameProvider = projectDirectoryNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
            this.SolutionDirectoryPathProvider = solutionDirectoryPathProvider;
            this.TargetFrameworkDirectoryNameProvider = targetFrameworkDirectoryNameProvider;
        }

        public Task<string> GetBuiltBinariesSourceDirectoryPath()
        {
            var solutionDirectoryPath = this.SolutionDirectoryPathProvider.GetSolutionDirectoryPath();
            var projectDirectoryName = this.ProjectDirectoryNameProvider.GetProjectDirectoryName();
            var buildOutputDirectoryName = this.BuildOutputDirectoryNameProvider.GetBuildOutputDirectoryName();
            var buildConfigurationDirectoryName = this.BuildConfigurationDirectoryNameProvider.GetBuildConfigurationDirectoryName();
            var targetFrameworkDirectoryName = this.TargetFrameworkDirectoryNameProvider.GetTargetFrameworkDirectoryName();

            var builtBinariesSourceDirectoryPath = this.StringlyTypedPathOperator.Combine(
                solutionDirectoryPath,
                projectDirectoryName,
                buildOutputDirectoryName,
                buildConfigurationDirectoryName,
                targetFrameworkDirectoryName);
            return Task.FromResult(builtBinariesSourceDirectoryPath);
        }
    }
}
