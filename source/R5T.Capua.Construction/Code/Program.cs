using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.Liverpool;


namespace R5T.Capua.Construction
{
    class Program : AsyncHostedServiceProgramBase
    {
        static async Task Main(string[] args)
        {
            await HostedServiceProgram.RunAsync<Program, Startup>();
        }


        private IDeployBuiltBinariesAction DeployToBuiltBinariesDirectoryAction { get; }


        public Program(IApplicationLifetime applicationLifetime,
            IDeployBuiltBinariesAction deployToBuiltBinariesDirectoryAction)
            : base(applicationLifetime)
        {
            this.DeployToBuiltBinariesDirectoryAction = deployToBuiltBinariesDirectoryAction;
        }

        protected override async Task SubMainAsync()
        {
            await this.DeployToBuiltBinariesDirectoryAction.RunAsync();
        }
    }
}
