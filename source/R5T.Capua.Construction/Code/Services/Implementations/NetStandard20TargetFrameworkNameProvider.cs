using System;


namespace R5T.Capua.Construction.Services
{
    /// <summary>
    /// Provides the "netstandard2.0" target framework name.
    /// </summary>
    public class NetStandard20TargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        public string GetTargetFrameworkName()
        {
            var targetFrameworkName = "netstandard2.0";
            return targetFrameworkName;
        }
    }
}
