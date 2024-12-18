﻿using CarBook.Application.Features.CQRS.Commands.BrandCommand;
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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BrandID);
            values.Fuel = command.Fuel;
            values.Transmisson = command.Transmisson;
            values.BigImageUrl = command.BigImageUrl;
            values.CoverImageUrl = command.CoverImageUrl;
            values.BrandID = command.BrandID;
            values.Km = command.Km;
            values.Luggage = command.Luggage;
            values.Seat = command.Seat;
            values.Model = command.Model;


            await _repository.UpdateAsync(values);
        }
    }
}
