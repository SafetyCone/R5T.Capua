using System;


namespace R5T.Capua.Construction.Services
{
    class TargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        public string GetTargetFrameworkName()
        {
            var targetFrameworkName = "netstandard2.0";
            return targetFrameworkName;
        }
    }
}
