using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.Liverpool;


namespace R5T.Capua.Construction
{
    class Program : HostedServiceProgramBase // AsyncHostedServiceProgramBase
    {
        public Program(IApplicationLifetime applicationLifetime)
            : base(applicationLifetime)
        {
        }

        //static async Task Main(string[] args)
        //{
        //    await HostedServiceProgram.RunAsync<Program>(args);
        //}

        //protected override Task SubMain()
        //{
        //    Console.WriteLine("Hello world!");

        //    throw new NotImplementedException();

        //    //return Task.CompletedTask;
        //}

        static void Main(string[] args)
        {
            HostedServiceProgram.Run<Program>(args);
        }

        protected override void SubMain()
        {
            Console.WriteLine("Hello world!");

            throw new NotImplementedException();

            //return Task.CompletedTask;
        }
    }
}
