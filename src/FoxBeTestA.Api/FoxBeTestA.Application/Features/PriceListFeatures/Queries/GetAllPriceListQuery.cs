using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.PriceListFeatures.Queries
{
    public class GetAllPriceListsQuery : IRequest<IEnumerable<PriceListDto>>
    {
        public class GetAllPriceListsQueryHandler : IRequestHandler<GetAllPriceListsQuery, IEnumerable<PriceListDto>>
        {
            private readonly IGenericProcessor<PriceList, PriceListDto, int> _PriceListProcessor;

            public GetAllPriceListsQueryHandler(IGenericProcessor<PriceList, PriceListDto, int> PriceListProcessor)
            {
                _PriceListProcessor = PriceListProcessor;
            }
            public async Task<IEnumerable<PriceListDto>> Handle(GetAllPriceListsQuery query, CancellationToken cancellationToken)
            {
                return await _PriceListProcessor.ExecuteGetAllToDto();
            }
        }
    }
}
