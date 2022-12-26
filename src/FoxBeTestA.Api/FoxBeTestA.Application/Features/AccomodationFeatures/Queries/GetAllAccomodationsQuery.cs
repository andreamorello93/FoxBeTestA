using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Data;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.AccomodationFeatures.Commands
{
    public class GetAllAccomodationsQuery : IRequest<IEnumerable<AccomodationDto>>
    {
        public class GetAllAccomodationsQueryHandler : IRequestHandler<GetAllAccomodationsQuery, IEnumerable<AccomodationDto>>
        {
            private readonly IGenericProcessor<Accomodation, AccomodationDto, int> _accomodationProcessor;

            public GetAllAccomodationsQueryHandler(IGenericProcessor<Accomodation, AccomodationDto, int> accomodationProcessor)
            {
                _accomodationProcessor = accomodationProcessor;
            }
            public async Task<IEnumerable<AccomodationDto>> Handle(GetAllAccomodationsQuery query, CancellationToken cancellationToken)
            {
                return await _accomodationProcessor.ExecuteGetAll();
            }
        }
    }
}
