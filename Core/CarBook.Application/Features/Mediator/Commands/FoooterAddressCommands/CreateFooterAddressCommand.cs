using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FoooterAddressCommands
{
    public class CreateFooterAddressCommand :IRequest
    {
        public string Description { get; set; }

        public String Address { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

    }
}
