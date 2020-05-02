using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// The default <see cref="ITargetFrameworkDirectoryNameProvider"/> implementation uses the <see cref="ITargetFrameworkDirectoryNameProvider"/> service and presumes that the target framework directory name is the same as the target framework name.
    /// </summary>
    public class DefaultTargetFrameworkDirectoryNameProvider : ITargetFrameworkDirectoryNameProvider
    {
        private ITargetFrameworkNameProvider TargetFrameworkNameProvider { get; }


        public DefaultTargetFrameworkDirectoryNameProvider(ITargetFrameworkNameProvider targetFrameworkNameProvider)
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
