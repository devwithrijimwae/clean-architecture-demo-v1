using myapp_domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace myapp_infrastructure.Repository
{
    public class CoindeskHttpClientService(HttpClient httpClient) : ICoindeskHttpClientService
    {
        public async Task<CoindeskData> GetData()
        {
            return await httpClient.GetFromJsonAsync<CoindeskData>("bpi/currentprice.json");
        }
    }
}
