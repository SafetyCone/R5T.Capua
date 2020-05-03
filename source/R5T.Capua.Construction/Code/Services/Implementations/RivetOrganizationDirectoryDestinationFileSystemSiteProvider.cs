using System;
using System.Threading.Tasks;

using R5T.Alamania;
using R5T.Gepidia;
using R5T.Gepidia.Destination;
using R5T.Gepidia.Local;
using R5T.Lombardy;

using R5T.Capua.Destination;


namespace R5T.Capua.Construction.Services
{
    class RivetOrganizationDirectoryDestinationFileSystemSiteProvider : IDestinationFileSystemSiteProvider
    {
        private IBinariesDestinationDirectoryName BinariesDestinationDirectoryName { get; }
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }
        private IProjectBinariesDestinationDirectoryNameProvider ProjectBinariesDestinationDirectoryNameProvider { get; }
        private IRivetOrganizationDirectoryPathProvider RivetOrganizationDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }



        public RivetOrganizationDirectoryDestinationFileSystemSiteProvider(
            IBinariesDestinationDirectoryName binariesDestinationDirectoryName,
            ILocalFileSystemOperator localFileSystemOperator,
            IProjectBinariesDestinationDirectoryNameProvider projectBinariesDestinationDirectoryNameProvider,
            IRivetOrganizationDirectoryPathProvider rivetOrganizationDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.BinariesDestinationDirectoryName = binariesDestinationDirectoryName;
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.ProjectBinariesDestinationDirectoryNameProvider = projectBinariesDestinationDirectoryNameProvider;
            this.RivetOrganizationDirectoryPathProvider = rivetOrganizationDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public Task<FileSystemSite> GetDestinationFileSystemSiteAsync()
        {
            var rivetOrganizationDirectoryPath = this.RivetOrganizationDirectoryPathProvider.GetRivetOrganizationDirectoryPath();
            var binariesDestinationDirectoryName = this.BinariesDestinationDirectoryName.GetBinariesDestinationDirectoryName();
            var projectBinariesDestinationDirectoryName = this.ProjectBinariesDestinationDirectoryNameProvider.GetProjectBinariesDestinationDirectoryName();

            var directoryPath = this.StringlyTypedPathOperator.Combine(rivetOrganizationDirectoryPath, binariesDestinationDirectoryName, projectBinariesDestinationDirectoryName);

            var fileSystemSite = FileSystemSite.New(directoryPath, this.LocalFileSystemOperator);
            return Task.FromResult(fileSystemSite);
        }
    }
}
