using System;


namespace R5T.Capua.Construction.Services
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
