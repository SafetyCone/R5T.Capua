using System;
using System.Threading.Tasks;

using R5T.Magyar.Extensions;

using R5T.T0064;


namespace R5T.Capua.Default
{
    [ServiceImplementationMarker]
    public class DateTimedDirectoryNameProvider : IDateTimedDirectoryNameProvider, IServiceImplementation
    {
        private IBuiltBinariesSourceDirectoryPathProvider BuiltBinariesSourceDirectoryPathProvider { get; }
        private IDirectoryLastModifiedProvider DirectoryLastModifiedProvider { get; }


        public DateTimedDirectoryNameProvider(
            IBuiltBinariesSourceDirectoryPathProvider builtBinariesSourceDirectoryPathProvider,
            IDirectoryLastModifiedProvider directoryLastModifiedProvider)
        {
            this.BuiltBinariesSourceDirectoryPathProvider = builtBinariesSourceDirectoryPathProvider;
            this.DirectoryLastModifiedProvider = directoryLastModifiedProvider;
        }

        public async Task<string> GetDateTimedDirectoryNameAsync()
        {
            var builtBinariesSourceDirectoryPath = await this.BuiltBinariesSourceDirectoryPathProvider.GetBuiltBinariesSourceDirectoryPath();

            var directoryLastModified = this.DirectoryLastModifiedProvider.GetDirectoryLastModifiedDateTime(builtBinariesSourceDirectoryPath);

            var dateTimedDirectoryName = directoryLastModified.ToYYYYMMDD_HHMMSS();
            return dateTimedDirectoryName;
        }
    }
}
