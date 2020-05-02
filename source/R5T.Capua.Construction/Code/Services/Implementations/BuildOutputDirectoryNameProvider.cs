using System;


namespace R5T.Capua.Construction.Services
{
    class BuildOutputDirectoryNameProvider : IBuildOutputDirectoryNameProvider
    {
        public string GetBuildOutputDirectoryName()
        {
            var buildOutputDirectoryName = @"bin";
            return buildOutputDirectoryName;
        }
    }
}
