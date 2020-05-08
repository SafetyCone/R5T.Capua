using System;
using System.Threading.Tasks;

using R5T.Magyar.Extensions;


namespace R5T.Capua.Default
{
    public class DateTimedDirectoryNameProvider : IDateTimedDirectoryNameProvider
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
