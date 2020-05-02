using System;

using Microsoft.Extensions.Options;


namespace R5T.Capua.Construction.Configuration
{
    class CapuaConfigurationConfigureOptions : IConfigureOptions<CapuaConfiguration>
    {
        private IOptions<Raw.CapuaConfiguration> RawCapuaConfiguration { get; }


        public CapuaConfigurationConfigureOptions(IOptions<Raw.CapuaConfiguration> rawCapuaConfiguration)
        {
            this.RawCapuaConfiguration = rawCapuaConfiguration;
        }

        public void Configure(CapuaConfiguration options)
        {
            var rawCapuaConfiguration = this.RawCapuaConfiguration.Value;

            options.SolutionDirectoryPath = rawCapuaConfiguration.SolutionDirectoryPath;
            options.ProjectName = rawCapuaConfiguration.ProjectName;
            options.BuildConfigurationName = rawCapuaConfiguration.BuildConfigurationName;
            options.TargetFrameworkName = rawCapuaConfiguration.TargetFrameworkName;
        }
    }
}
