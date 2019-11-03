using System;
using System.Threading.Tasks;
using Empowered.NetCore3Templates.IntegrationTests.Helpers;
using Empowered.NetCore3Templates.Protocol;
using Empowered.NetCore3Templates.Protocol.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Empowered.NetCore3Templates.IntegrationTests
{
    [TestClass]
    public class About_Should
    {
        public MyClient Client => MyClientFactory.CreateClient();
        
        [TestMethod]
        public async Task ResponseOkWithFilledObject()
        {
            var response = await this.Client.AboutGet();

            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json);
            var about = JsonConvert.DeserializeObject<About>(json);
            
            Assert.IsNotNull(about.Description);
            Assert.IsNotNull(about.Version);
            Assert.IsNotNull(about.Environment);
        }
    }
}