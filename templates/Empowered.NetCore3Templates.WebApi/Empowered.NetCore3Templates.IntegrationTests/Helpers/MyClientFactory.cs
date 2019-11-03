using Empowered.NetCore3Templates.Protocol;

namespace Empowered.NetCore3Templates.IntegrationTests.Helpers
{
    public class MyClientFactory
    {
        public static MyClient CreateClient()
        {
            return new MyClient(new WebApplicationFactory().CreateClient());
        }
    }
}