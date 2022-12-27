using FoxBeTestA.Application.Features.PriceListFeatures.Commands;
using FoxBeTestA.Application.Features.PriceListFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FoxBeTestA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceListController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpPost]
        public async Task<IActionResult> Create(CreatePriceListCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllPriceListsQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await Mediator.Send(new GetPriceListByIdQuery {Id = id});
            
            if(entity == null)
                return NotFound();

            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeletePriceListByIdCommand { Id = id }));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdatePriceListCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
    }
}
