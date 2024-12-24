using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using CarBook.Application.Features.Mediator.Results.PricingResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingByIdQueryHandler :IRequestHandler<GetPricingByIdQuery,GetPricingByIdQueryResult>
    {
        private readonly IRepository<Pricing> _reposityory;

        public GetPricingByIdQueryHandler(IRepository<Pricing> reposityory)
        {
            _reposityory = reposityory;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        { 
            var values =await _reposityory.GetByIdAsync(request.Id);
            return new GetPricingByIdQueryResult
            {
                Name = values.Name,
                PrincingID = values.PrincingID
            };
          
        }
    }
}
