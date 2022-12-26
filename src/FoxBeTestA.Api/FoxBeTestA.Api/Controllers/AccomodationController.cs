using FoxBeTestA.Application.Features.AccomodationFeatures.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FoxBeTestA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccomodationController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpPost]
        public async Task<IActionResult> Create(CreateAccomodationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllAccomodationsQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await Mediator.Send(new GetAccomodationByIdQuery {Id = id});
            
            if(entity == null)
                return NotFound();

            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteAccomodationByIdCommand { Id = id }));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateAccomodationCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
    }
}
