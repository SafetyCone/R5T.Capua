using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0064;


namespace R5T.Capua.Default
{
    [ServiceImplementationMarker]
    public class LatestDirectoryPathProvider : ILatestDirectoryPathProvider, IServiceImplementation
    {
        public const string LatestDirectoryName = "Latest";


        private IDestinationRootDirectoryPathProvider DestinationRootDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public LatestDirectoryPathProvider(
            IDestinationRootDirectoryPathProvider destinationRootDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.DestinationRootDirectoryPathProvider = destinationRootDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetLatestDirectoryPath()
        {
            var destinationRootDirectoryPath = await this.DestinationRootDirectoryPathProvider.GetDestinationRootDirectoryPathAsync();

            var latestDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(destinationRootDirectoryPath, LatestDirectoryPathProvider.LatestDirectoryName);
            return latestDirectoryPath;
        }
    }
}
