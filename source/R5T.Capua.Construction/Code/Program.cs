using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.Liverpool;


namespace R5T.Capua.Construction
{
    class Program : AsyncHostedServiceProgramBase
    {
        public Program(IApplicationLifetime applicationLifetime)
            : base(applicationLifetime)
        {
        }

        static async Task Main(string[] args)
        {
            await HostedServiceProgram.RunAsync<Program, Startup>();
        }

        protected override Task SubMainAsync()
        {
            Console.WriteLine("Hello world!");

            throw new NotImplementedException();

            //return Task.CompletedTask;
        }
    }
}
