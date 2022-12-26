using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.AccomodationFeatures.Commands
{
    public class DeleteAccomodationByIdCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public class DeleteAccomodationByIdCommandHandler : IRequestHandler<DeleteAccomodationByIdCommand, bool>
        {
            private readonly IGenericProcessor<Accomodation, AccomodationDto, int> _accomodationProcessor;

            public DeleteAccomodationByIdCommandHandler(IGenericProcessor<Accomodation, AccomodationDto, int> accomodationProcessor)
            {
                _accomodationProcessor = accomodationProcessor;
            }
            public async Task<bool> Handle(DeleteAccomodationByIdCommand command, CancellationToken cancellationToken)
            {
                return await _accomodationProcessor.ExecuteDelete(command.Id);
            }
        }
    }
}
