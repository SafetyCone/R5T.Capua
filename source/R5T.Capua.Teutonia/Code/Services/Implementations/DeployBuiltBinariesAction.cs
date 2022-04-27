using System;
using System.Threading.Tasks;

using R5T.Gepidia.Destination;
using R5T.Gepidia.Source;
using R5T.Teutonia;using R5T.T0064;


namespace R5T.Capua.Teutonia
{[ServiceImplementationMarker]
    public class DeployBuiltBinariesAction : IDeployBuiltBinariesAction,IServiceImplementation
    {
        private IFileSystemCloningOperator FileSystemCloningOperator { get; }
        private ISourceFileSystemSiteProvider SourceFileSystemSiteProvider { get; }
        private IDestinationFileSystemSitesProvider DestinationFileSystemSitesProvider { get; }


        public DeployBuiltBinariesAction(
            IFileSystemCloningOperator fileSystemCloningOperator,
            ISourceFileSystemSiteProvider sourceFileSystemSiteProvider,
            IDestinationFileSystemSitesProvider destinationFileSystemSitesProvider)
        {
            this.FileSystemCloningOperator = fileSystemCloningOperator;
            this.SourceFileSystemSiteProvider = sourceFileSystemSiteProvider;
            this.DestinationFileSystemSitesProvider = destinationFileSystemSitesProvider;
        }

        public async Task RunAsync()
        {
            var gettingSourceFileSystemSite = this.SourceFileSystemSiteProvider.GetSourceFileSystemSiteAsync();
            var gettingDestinationFileSystemSites = this.DestinationFileSystemSitesProvider.GetDestinationFileSystemSitesAsync();

            var sourceFileSystemSite = await gettingSourceFileSystemSite;
            var destinationFileSystemSites = await gettingDestinationFileSystemSites;

            foreach (var destinationFileSystemSite in destinationFileSystemSites)
            {
                this.FileSystemCloningOperator.Clone(sourceFileSystemSite, destinationFileSystemSite);
            }
        }
    }
}
