using System;
using System.Threading.Tasks;

using R5T.Lombardy;


namespace R5T.Capua.Default
{
    public class DateTimedDirectoryPathProvider : IDateTimedDirectoryPathProvider
    {
        private IDateTimedDirectoryNameProvider DateTimedDirectoryNameProvider { get; }
        private IDestinationRootDirectoryPathProvider DestinationRootDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DateTimedDirectoryPathProvider(
            IDateTimedDirectoryNameProvider dateTimedDirectoryNameProvider,
            IDestinationRootDirectoryPathProvider destinationRootDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.DateTimedDirectoryNameProvider = dateTimedDirectoryNameProvider;
            this.DestinationRootDirectoryPathProvider = destinationRootDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetDateTimedDirectoryPathAsync()
        {
            var destinationRootDirectoryPath = await this.DestinationRootDirectoryPathProvider.GetDestinationRootDirectoryPathAsync();

            var dateTimedDirectoryName = await this.DateTimedDirectoryNameProvider.GetDateTimedDirectoryNameAsync();

            var dateTimedDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(destinationRootDirectoryPath, dateTimedDirectoryName);
            return dateTimedDirectoryPath;
        }
    }
}
