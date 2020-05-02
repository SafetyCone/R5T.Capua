using System;


namespace R5T.Capua.Construction.Services
{
    class BuildConfigurationDirectoryNameProvider : IBuildConfigurationDirectoryNameProvider
    {
        private IBuildConfigurationNameProvider BuildConfigurationNameProvider { get; }


        public BuildConfigurationDirectoryNameProvider(IBuildConfigurationNameProvider buildConfigurationNameProvider)
        {
            this.BuildConfigurationNameProvider = buildConfigurationNameProvider;
        }

        public string GetBuildConfigurationDirectoryName()
        {
            var buildConfigurationName = this.BuildConfigurationNameProvider.GetBuildConfigurationName();

            var buildConfigurationDirectoryName = buildConfigurationName; // Presume the build configuration directory name is the same as the build configuration name.
            return buildConfigurationDirectoryName;
        }
    }
}
