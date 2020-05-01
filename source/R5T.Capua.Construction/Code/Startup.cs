using System;

using Microsoft.Extensions.Logging;

using R5T.Richmond;


namespace R5T.Capua.Construction
{
    class Startup : StartupBase
    {
        public Startup(ILogger<StartupBase> logger)
            : base(logger)
        {
        }
    }
}
