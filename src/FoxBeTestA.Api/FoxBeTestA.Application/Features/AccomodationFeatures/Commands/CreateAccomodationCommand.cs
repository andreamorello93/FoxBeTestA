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
    public class CreateAccomodationCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal BaseRoomPrice { get; set; }

        public class CreateAccomodationCommandHandler : IRequestHandler<CreateAccomodationCommand, int>
        {
            private readonly IGenericProcessor<Accomodation, AccomodationDto, int> _accomodationProcessor;
            private readonly IMapper _mapper;

            public CreateAccomodationCommandHandler(IGenericProcessor<Accomodation, AccomodationDto, int> accomodationProcessor, IMapper mapper)
            {
                _accomodationProcessor = accomodationProcessor;
                _mapper = mapper;
            }
            public async Task<int> Handle(CreateAccomodationCommand command, CancellationToken cancellationToken)
            {
                var entity= await _accomodationProcessor.ExecuteInsert(_mapper.Map<Accomodation>(command));

                return entity.Id;
            }
        }
    }
}
