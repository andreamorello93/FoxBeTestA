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
    public class GetAccomodationByIdQuery : IRequest<AccomodationDto>
    {
        public int Id { get; set; }
        public class GetAccomodationByIdQueryHandler : IRequestHandler<GetAccomodationByIdQuery, AccomodationDto>
        {
            private readonly IGenericProcessor<Accomodation, AccomodationDto, int> _accomodationProcessor;

            public GetAccomodationByIdQueryHandler(IGenericProcessor<Accomodation, AccomodationDto, int> accomodationProcessor)
            {
                _accomodationProcessor = accomodationProcessor;
            }
            public async Task<AccomodationDto> Handle(GetAccomodationByIdQuery query, CancellationToken cancellationToken)
            {
                return await _accomodationProcessor.ExecuteGetById(query.Id);
            }
        }
    }
}
