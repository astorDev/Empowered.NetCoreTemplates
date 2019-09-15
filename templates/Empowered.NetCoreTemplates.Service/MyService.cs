using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Empowered.NetCoreTemplates.Service
{
    public class MyService : IHostedService
    {
        public IHostingEnvironment HostingEnvironment { get; }
        public ILogger<MyService> Logger { get; }

        public MyService(IHostingEnvironment hostingEnvironment, ILogger<MyService> logger)
        {
            this.HostingEnvironment = hostingEnvironment;
            this.Logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            this.Logger.LogTrace("Service started, Environment: {0}", this.HostingEnvironment.EnvironmentName);
            await Task.Delay(2, cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(3, cancellationToken);
        }
    }
}