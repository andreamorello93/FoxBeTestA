using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.AccomodationFeatures.Queries
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
                return await _accomodationProcessor.ExecuteGetAllToDto();
            }
        }
    }
}
