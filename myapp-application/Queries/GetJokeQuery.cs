using MediatR;
using myapp_domain.Interfaces;
using myapp_domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp_application.Queries
{
    public record GetJokeQuery() : IRequest<JokeModel>;
    public class GetJokeQueryHandler(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetJokeQuery, JokeModel>
    {
        public async Task<JokeModel> Handle(GetJokeQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetJoke();
        }
    }
}
