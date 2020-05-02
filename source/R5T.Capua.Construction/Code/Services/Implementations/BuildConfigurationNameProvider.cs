using System;


namespace R5T.Capua.Construction.Services
{
    class BuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        public string GetBuildConfigurationName()
        {
            var buildConfigurationName = "Debug";
            return buildConfigurationName;
        }
    }
}
