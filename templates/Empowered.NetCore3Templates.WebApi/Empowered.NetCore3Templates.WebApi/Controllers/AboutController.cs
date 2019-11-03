using System.Reflection;
using Empowered.NetCore3Templates.Protocol;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Empowered.NetCore3Templates.Protocol.Models;

namespace Empowered.NetCore3Templates.WebApi.Controllers
{
    [ApiController]
    [Route(Uris.About)]
    public class AboutController
    {
        public IHostEnvironment Environment { get; }

        public AboutController(IHostEnvironment environment)
        {
            this.Environment = environment;
        }

        [HttpGet]
        public About Get()
        {
            return new About
            {
                Description = "Empowered.NetCore3Templates - my web api",
                Version = this.GetType().Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version,
                Environment = this.Environment.EnvironmentName
            };
        }
    }
}