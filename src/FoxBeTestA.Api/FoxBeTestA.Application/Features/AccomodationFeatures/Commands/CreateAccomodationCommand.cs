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
    public class CreateAccomodationCommand : IRequest<int>
    {
        public string Name { get; set; }

        public class CreateAccomodationCommandHandler : IRequestHandler<CreateAccomodationCommand, int>
        {
            private readonly IGenericProcessor<Accomodation, AccomodationDto, int> _accomodationProcessor;
            public CreateAccomodationCommandHandler(IGenericProcessor<Accomodation, AccomodationDto, int> accomodationProcessor)
            {
                _accomodationProcessor = accomodationProcessor;
            }
            public async Task<int> Handle(CreateAccomodationCommand command, CancellationToken cancellationToken)
            {
                var accomodation = new Accomodation();

                accomodation.Name = command.Name;

                var entity= await _accomodationProcessor.ExecuteInsert(accomodation);

                return entity.Id;
            }
        }
    }
}
