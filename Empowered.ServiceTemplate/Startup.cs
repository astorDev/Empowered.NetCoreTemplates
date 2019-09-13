using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Empowered.ServiceTemplate
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }
    }
}
