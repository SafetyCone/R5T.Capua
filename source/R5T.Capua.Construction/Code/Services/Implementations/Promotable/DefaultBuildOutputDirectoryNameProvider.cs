using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// The default "bin" build output directory name provider.
    /// </summary>
    public class DefaultBuildOutputDirectoryNameProvider : IBuildOutputDirectoryNameProvider
    {
        public string GetBuildOutputDirectoryName()
        {
            var buildOutputDirectoryName = @"bin";
            return buildOutputDirectoryName;
        }
    }
}
