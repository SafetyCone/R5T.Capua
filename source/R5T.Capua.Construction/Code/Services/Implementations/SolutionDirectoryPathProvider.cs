using System;


namespace R5T.Capua.Construction.Services
{
    class SolutionDirectoryPathProvider : ISolutionDirectoryPathProvider
    {
        public string GetSolutionDirectoryPath()
        {
            var solutionDirectoryPath = @"C:\GitHub\MinexAutomation\R5T.Capua\source";
            return solutionDirectoryPath;
        }
    }
}
