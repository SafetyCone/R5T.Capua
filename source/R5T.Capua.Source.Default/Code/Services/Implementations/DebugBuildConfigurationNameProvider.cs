using System;


namespace R5T.Capua.Source.Default
{
    /// <summary>
    /// The Debug build configuration name provider.
    /// </summary>
    public class DebugBuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        public string GetBuildConfigurationName()
        {
            var buildConfigurationName = "Debug";
            return buildConfigurationName;
        }
    }
}
