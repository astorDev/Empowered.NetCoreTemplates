using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Empowered.ServiceTemplate
{
    public class MyService : IHostedService
    {
        public ILogger<MyService> Logger { get; }
        public IHostingEnvironment HostingEnvironment { get; }

        public MyService(ILogger<MyService> logger, IHostingEnvironment hostingEnvironment)
        {
            Logger = logger;
            HostingEnvironment = hostingEnvironment;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            this.Logger.LogTrace("Service started. Environment: {0}", this.HostingEnvironment.EnvironmentName);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            this.Logger.LogTrace("Service stopped");
        }
    }
}
