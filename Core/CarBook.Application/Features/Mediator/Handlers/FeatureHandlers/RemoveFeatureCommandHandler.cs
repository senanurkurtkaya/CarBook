using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
    {
        public Task<Unit> Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
