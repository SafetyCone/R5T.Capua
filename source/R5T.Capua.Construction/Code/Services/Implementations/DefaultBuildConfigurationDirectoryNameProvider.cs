using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// The default <see cref="IBuildConfigurationDirectoryNameProvider"/> implementation uses the <see cref="IBuildConfigurationNameProvider"/> service and presumes that the build configuration directory name is the same as the build configuration name.
    /// </summary>
    public class DefaultBuildConfigurationDirectoryNameProvider : IBuildConfigurationDirectoryNameProvider
    {
        private IBuildConfigurationNameProvider BuildConfigurationNameProvider { get; }


        public DefaultBuildConfigurationDirectoryNameProvider(IBuildConfigurationNameProvider buildConfigurationNameProvider)
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
