using System;
using System.Threading.Tasks;

using R5T.Alamania;
using R5T.Lombardy;

using R5T.Capua.Destination;


namespace R5T.Capua.Default
{
    public class RivetOrganizationDirectoryDestinationRootDirectoryPathProvider : IDestinationRootDirectoryPathProvider
    {
        private IBinariesDestinationDirectoryName BinariesDestinationDirectoryName { get; }
        private IProjectBinariesDestinationDirectoryNameProvider ProjectBinariesDestinationDirectoryNameProvider { get; }
        private IRivetOrganizationDirectoryPathProvider RivetOrganizationDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public RivetOrganizationDirectoryDestinationRootDirectoryPathProvider(
            IBinariesDestinationDirectoryName binariesDestinationDirectoryName,
            IProjectBinariesDestinationDirectoryNameProvider projectBinariesDestinationDirectoryNameProvider,
            IRivetOrganizationDirectoryPathProvider rivetOrganizationDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.BinariesDestinationDirectoryName = binariesDestinationDirectoryName;
            this.ProjectBinariesDestinationDirectoryNameProvider = projectBinariesDestinationDirectoryNameProvider;
            this.RivetOrganizationDirectoryPathProvider = rivetOrganizationDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public Task<string> GetDestinationRootDirectoryPathAsync()
        {
            var rivetOrganizationDirectoryPath = this.RivetOrganizationDirectoryPathProvider.GetRivetOrganizationDirectoryPath();
            var binariesDestinationDirectoryName = this.BinariesDestinationDirectoryName.GetBinariesDestinationDirectoryName();
            var projectBinariesDestinationDirectoryName = this.ProjectBinariesDestinationDirectoryNameProvider.GetProjectBinariesDestinationDirectoryName();

            var destinationRootDirectoryPath = this.StringlyTypedPathOperator.Combine(rivetOrganizationDirectoryPath, binariesDestinationDirectoryName, projectBinariesDestinationDirectoryName);
            return Task.FromResult(destinationRootDirectoryPath);
        }
    }
}
