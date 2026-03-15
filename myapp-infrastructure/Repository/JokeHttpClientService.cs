using myapp_domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace myapp_infrastructure.Repository
{
    public class JokeHttpClientService(HttpClient httpClient) : IJokeHttpClientService
    {
        public async Task<JokeModel> GetData()
        {
            return await httpClient.GetFromJsonAsync<JokeModel>("random_joke");
        }
    }
}