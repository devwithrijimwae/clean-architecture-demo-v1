using myapp_domain.Models;

namespace myapp_infrastructure.Repository
{
    public interface ICoindeskHttpClientService
    {
        Task<CoindeskData> GetData();
    }
}
