using System;

using R5T.Palembang;


namespace R5T.Capua.Source.Default
{
    /// <summary>
    /// The default <see cref="ITargetFrameworkDirectoryNameProvider"/> implementation uses the <see cref="ITargetFrameworkDirectoryNameProvider"/> service and presumes that the target framework directory name is the same as the target framework name.
    /// </summary>
    public class TargetFrameworkDirectoryNameProvider : ITargetFrameworkDirectoryNameProvider
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
