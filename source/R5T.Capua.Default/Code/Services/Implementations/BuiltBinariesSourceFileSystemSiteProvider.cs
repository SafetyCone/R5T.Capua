using System;
using System.Threading.Tasks;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Gepidia.Source;

using R5T.T0064;


namespace R5T.Capua.Default
{
    [ServiceImplementationMarker]
    public class BuiltBinariesSourceFileSystemSiteProvider : ISourceFileSystemSiteProvider, IServiceImplementation
    {
        private IBuiltBinariesSourceDirectoryPathProvider BuiltBinariesSourceDirectoryPathProvider { get; }
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }


        public BuiltBinariesSourceFileSystemSiteProvider(
            IBuiltBinariesSourceDirectoryPathProvider builtBinariesSourceDirectoryPathProvider,
            ILocalFileSystemOperator localFileSystemOperator
            )
        {
            this.BuiltBinariesSourceDirectoryPathProvider = builtBinariesSourceDirectoryPathProvider;
            this.LocalFileSystemOperator = localFileSystemOperator;
        }

        public async Task<FileSystemSite> GetSourceFileSystemSiteAsync()
        {
            var builtBinariesSourceDirectoryPath = await this.BuiltBinariesSourceDirectoryPathProvider.GetBuiltBinariesSourceDirectoryPath();

            var sourceFileSystemSite = FileSystemSite.New(builtBinariesSourceDirectoryPath, this.LocalFileSystemOperator);
            return sourceFileSystemSite;
        }
    }
}
