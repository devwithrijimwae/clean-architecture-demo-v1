using myapp_domain.Models;

namespace myapp_domain.Interfaces
{ 
            public interface IExternalVendorRepository
        {
            Task<CoindeskData> GetData();
            Task<JokeModel> GetJoke();
            }
}


