using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Gepidia;
using R5T.Gepidia.Destination;
using R5T.Gepidia.Local;


namespace R5T.Capua.Default
{
    public class RivetOrganizationDirectoryDestinationFileSystemSitesProvider : IDestinationFileSystemSitesProvider
    {
        private IDateTimedDirectoryPathProvider DateTimedDirectoryPathProvider { get; }
        private ILatestDirectoryPathProvider LatestDirectoryPathProvider { get; }
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }


        public RivetOrganizationDirectoryDestinationFileSystemSitesProvider(
            IDateTimedDirectoryPathProvider dateTimedDirectoryPathProvider,
            ILatestDirectoryPathProvider latestDirectoryPathProvider,
            ILocalFileSystemOperator localFileSystemOperator
            )
        {
            this.DateTimedDirectoryPathProvider = dateTimedDirectoryPathProvider;
            this.LatestDirectoryPathProvider = latestDirectoryPathProvider;
            this.LocalFileSystemOperator = localFileSystemOperator;
        }

        public async Task<IEnumerable<FileSystemSite>> GetDestinationFileSystemSitesAsync()
        {
            var latestDirectoryPath = await this.LatestDirectoryPathProvider.GetLatestDirectoryPath();

            var latestDirectoryPathFileSystemSite = FileSystemSite.New(latestDirectoryPath, this.LocalFileSystemOperator);

            var dateTimedDirectoryPath = await this.DateTimedDirectoryPathProvider.GetDateTimedDirectoryPathAsync();

            var dateTimedDirectoryPathFileSystemSite = FileSystemSite.New(dateTimedDirectoryPath, this.LocalFileSystemOperator);

            var output = new[]
            {
                latestDirectoryPathFileSystemSite,
                dateTimedDirectoryPathFileSystemSite,
            };
            return output;
        }
    }
}
