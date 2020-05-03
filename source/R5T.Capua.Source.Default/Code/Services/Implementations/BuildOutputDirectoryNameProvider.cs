using System;


namespace R5T.Capua.Source.Default
{
    /// <summary>
    /// The default "bin" build output directory name provider.
    /// </summary>
    public class BuildOutputDirectoryNameProvider : IBuildOutputDirectoryNameProvider
    {
        public string GetBuildOutputDirectoryName()
        {
            var buildOutputDirectoryName = @"bin";
            return buildOutputDirectoryName;
        }
    }
}
