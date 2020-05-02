using System;

using Microsoft.Extensions.Options;

using R5T.Gepidia;
using R5T.Gepidia.Local;


namespace R5T.Capua.Construction.Services
{
    class SourceFileSystemSiteProvider : ISourceFileSystemSiteProvider
    {
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }
        private IOptions<Configuration.CapuaConfiguration> CapuaConfiguration { get; }


        public SourceFileSystemSiteProvider(
            ILocalFileSystemOperator localFileSystemOperator,
            IOptions<Configuration.CapuaConfiguration> capuaConfiguration)
        {
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.CapuaConfiguration = capuaConfiguration;
        }

        public FileSystemSite GetSourceFileSystemSite()
        {
            var capuaConfiguration = this.CapuaConfiguration.Value;

            var directoryPath = @"C:\Temp\Source";

            var output = FileSystemSite.New(directoryPath, this.LocalFileSystemOperator);
            return output;
        }
    }
}
