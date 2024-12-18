

using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateContactCommand Command)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = Command.Name,
                Email = Command.Email,
                Message = Command.Message,
                SendDate = Command.SendDate,
                Subject = Command.Subject,

            });
        }
    }
}
