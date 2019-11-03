using System.Net.Http;
using System.Threading.Tasks;

namespace Empowered.NetCore3Templates.Protocol
{
    public class MyClient
    {
        public HttpClient Client { get; }

        public MyClient(HttpClient client)
        {
            this.Client = client;
        }

        public async Task<HttpResponseMessage> AboutGet()
        {
            return await this.Client.GetAsync(Uris.About);
        }
    }
}