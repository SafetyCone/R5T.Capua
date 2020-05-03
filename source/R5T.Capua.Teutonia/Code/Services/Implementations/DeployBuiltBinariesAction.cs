using System;
using System.Threading.Tasks;

using R5T.Gepidia.Destination;
using R5T.Gepidia.Source;
using R5T.Teutonia;


namespace R5T.Capua.Teutonia
{
    public class DeployBuiltBinariesAction : IDeployBuiltBinariesAction
    {
        private IFileSystemCloningOperator FileSystemCloningOperator { get; }
        private ISourceFileSystemSiteProvider SourceFileSystemSiteProvider { get; }
        private IDestinationFileSystemSiteProvider DestinationFileSystemSiteProvider { get; }


        public async Task RunAsync()
        {
            var gettingSourceFileSystemSite = this.SourceFileSystemSiteProvider.GetSourceFileSystemSiteAsync();
            var gettingDestinationFileSystemSite = this.DestinationFileSystemSiteProvider.GetDestinationFileSystemSiteAsync();

            var sourceFileSystemSite = await gettingSourceFileSystemSite;
            var destinationFileSystemSite = await gettingDestinationFileSystemSite;

            this.FileSystemCloningOperator.Clone(sourceFileSystemSite, destinationFileSystemSite);
        }
    }
}
