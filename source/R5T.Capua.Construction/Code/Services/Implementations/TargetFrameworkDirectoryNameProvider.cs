using System;


namespace R5T.Capua.Construction.Services
{
    class TargetFrameworkDirectoryNameProvider : ITargetFrameworkDirectoryNameProvider
    {
        private ITargetFrameworkNameProvider TargetFrameworkNameProvider { get; }


        public TargetFrameworkDirectoryNameProvider(ITargetFrameworkNameProvider targetFrameworkNameProvider)
        {
            this.TargetFrameworkNameProvider = targetFrameworkNameProvider;
        }

        public string GetTargetFrameworkDirectoryName()
        {
            var targetFrameworkName = this.TargetFrameworkNameProvider.GetTargetFrameworkName();

            var targetFrameworkDirectoryName = targetFrameworkName; // Presume the target framework directory name is the same as the target framework name.
            return targetFrameworkDirectoryName;
        }
    }
}
