using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.Liverpool;
using R5T.Teutonia;

using R5T.Capua.Construction.Services;


namespace R5T.Capua.Construction
{
    class Program : AsyncHostedServiceProgramBase
    {
        private IFileSystemCloningOperator FileSystemCloningOperator { get; }
        private ISourceFileSystemSiteProvider SourceFileSystemSiteProvider { get; }
        private IDestinationFileSystemSiteProvider DestinationFileSystemSiteProvider { get; }


        public Program(IApplicationLifetime applicationLifetime,
            IFileSystemCloningOperator fileSystemCloningOperator,
            ISourceFileSystemSiteProvider sourceFileSystemSiteProvider,
            IDestinationFileSystemSiteProvider destinationFileSystemSiteProvider)
            : base(applicationLifetime)
        {
            this.FileSystemCloningOperator = fileSystemCloningOperator;
            this.SourceFileSystemSiteProvider = sourceFileSystemSiteProvider;
            this.DestinationFileSystemSiteProvider = destinationFileSystemSiteProvider;
        }

        static async Task Main(string[] args)
        {
            await HostedServiceProgram.RunAsync<Program, Startup>();
        }

        protected override Task SubMainAsync()
        {
            var sourceFileSystemSite = this.SourceFileSystemSiteProvider.GetSourceFileSystemSite();
            var destinationFileSystemSite = this.DestinationFileSystemSiteProvider.GetDestinationFileSystemSite();

            this.FileSystemCloningOperator.Clone(sourceFileSystemSite, destinationFileSystemSite);

            return Task.CompletedTask;
        }
    }
}
