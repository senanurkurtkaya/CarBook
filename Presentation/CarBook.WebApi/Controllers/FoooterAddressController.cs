using CarBook.Application.Features.Mediator.Commands.FoooterAddressCommands;
using CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using CarBook.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoooterAddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FoooterAddressController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var values = await _mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt Adres Bilgisi Eklendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetFooterAddress(int id)
        {
            var values = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult>RemoveFooterAddress(int id)
        {
          await _mediator.Send(new RemoveFooterAddressCommand(id));
            return Ok("Alt Adres Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult>UpdateFooterAddress(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt Adress Bilgisi Güncellendi "); 
        }
    }
}
