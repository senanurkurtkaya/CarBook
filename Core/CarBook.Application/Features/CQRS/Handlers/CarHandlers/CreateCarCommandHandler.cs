using CarBook.Application.Features.CQRS.Commands.BrandCommand;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand Command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = Command.BigImageUrl,
                Luggage = Command.Luggage,
                Km = Command.Km,    
                Model = Command.Model,
                Seat = Command.Seat,
                Transmisson = Command.Transmisson,
                CoverImageUrl = Command.CoverImageUrl,
                BrandID = Command.BrandID,
                Fuel = Command.Fuel,    

            });
        }
    }
}
