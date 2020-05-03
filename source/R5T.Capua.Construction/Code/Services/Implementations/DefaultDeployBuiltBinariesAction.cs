using System;
using System.Threading.Tasks;

using R5T.Teutonia;


namespace R5T.Capua.Construction.Services
{
    class DefaultDeployBuiltBinariesAction : IDeployBuiltBinariesAction
    {
        private IFileSystemCloningOperator FileSystemCloningOperator { get; }
        private ISourceFileSystemSiteProvider SourceFileSystemSiteProvider { get; }
        private IDestinationFileSystemSiteProvider DestinationFileSystemSiteProvider { get; }


        public Task RunAsync()
        {
            var sourceFileSystemSite = this.SourceFileSystemSiteProvider.GetSourceFileSystemSite();
            var destinationFileSystemSite = this.DestinationFileSystemSiteProvider.GetDestinationFileSystemSite();

            this.FileSystemCloningOperator.Clone(sourceFileSystemSite, destinationFileSystemSite);

            return Task.CompletedTask;
        }
    }
}
