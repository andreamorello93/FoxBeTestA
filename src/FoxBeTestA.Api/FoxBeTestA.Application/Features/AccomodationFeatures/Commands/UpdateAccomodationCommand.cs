using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.AccomodationFeatures.Commands
{
    public class UpdateAccomodationCommand : IRequest<Accomodation>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public class UpdateAccomodationCommandHandler : IRequestHandler<UpdateAccomodationCommand, Accomodation>
        {
            private readonly IGenericProcessor<Accomodation, AccomodationDto, int> _accomodationProcessor;
            private readonly IMapper _mapper;

            public UpdateAccomodationCommandHandler(IGenericProcessor<Accomodation, AccomodationDto, int> accomodationProcessor, IMapper mapper)
            {
                _accomodationProcessor = accomodationProcessor;
                _mapper = mapper;
            }
            public async Task<Accomodation> Handle(UpdateAccomodationCommand command, CancellationToken cancellationToken)
            {
                var accomodation = _mapper.Map<Accomodation>(command);
                return await _accomodationProcessor.ExecuteUpdate(accomodation.Id, accomodation);
            }
        }
    }
}
