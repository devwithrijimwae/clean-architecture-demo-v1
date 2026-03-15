using MediatR;
using myapp_domain.Interfaces;
using myapp_domain.Models;

namespace myapp_application.Queries
{
    public record GetCoinkdeskDataQuery() : IRequest<CoindeskData>;
    public class GetCoinkdeskDataQueryHandler(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetCoinkdeskDataQuery, CoindeskData>
    {
        public async Task<CoindeskData> Handle(GetCoinkdeskDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetData();
        }
    }
}