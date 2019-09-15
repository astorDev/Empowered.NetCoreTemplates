using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Empowered.NetCoreTemplates.Service
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
                .ConfigureHostConfiguration(config =>
                {
                    config.AddCommandLine(args);
                })
                .ConfigureAppConfiguration((context, config) =>
                {
                    var env = context.HostingEnvironment.EnvironmentName;

                    config.AddJsonFile("appsettings.json");
                    config.AddJsonFile($"appsettings.{env}.json", true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IHostedService, MyService>();
                    var startup = new Startup(hostContext.Configuration);
                    startup.ConfigureServices(services);
                })
                .ConfigureLogging((context, logging) =>
                {
                    logging.AddConfiguration(context.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                });

            await builder.RunConsoleAsync();
        }
    }
}