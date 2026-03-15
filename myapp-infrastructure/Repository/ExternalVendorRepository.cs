using myapp_domain.Interfaces;
using myapp_domain.Models;

namespace myapp_infrastructure.Repository
{
    public class ExternalVendorRepository(ICoindeskHttpClientService coindeskHttpClientService,
       IJokeHttpClientService jokeHttpClientService)
       : IExternalVendorRepository

    {
        public async Task<CoindeskData> GetData()
        {
            return await coindeskHttpClientService.GetData();
        }
        public async Task<JokeModel> GetJoke()
        {
            return await jokeHttpClientService.GetData();
        }

    }
}