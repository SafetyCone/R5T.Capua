using System;


namespace R5T.Capua.Construction.Services
{
    public class ConstructorBasedSolutionDirectoryPathProvider : ISolutionDirectoryPathProvider
    {
        private string SolutionDirectoryPath { get; }


        public ConstructorBasedSolutionDirectoryPathProvider(string solutionDirectoryPath)
        {
            this.SolutionDirectoryPath = solutionDirectoryPath;
        }

        public string GetSolutionDirectoryPath()
        {
            var solutionDirectoryPath = this.SolutionDirectoryPath;
            return solutionDirectoryPath;
        }
    }
}
