using System.Reflection;
using Empowered.NetCoreTemplates.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Empowered.NetCoreTemplates.WebApi.Controllers
{
    [ApiController]
    [Route("about")]
    public class AboutController
    {
        public IHostingEnvironment HostingEnvironment { get; }

        public AboutController(IHostingEnvironment hostingEnvironment)
        {
            this.HostingEnvironment = hostingEnvironment;
        }
        
        [HttpGet]
        public About Get()
        {
            return new About()
            {
                Description = "my web api",
                Version = this.GetType().Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version,
                Environment = this.HostingEnvironment.EnvironmentName
            };
        }
    }
}