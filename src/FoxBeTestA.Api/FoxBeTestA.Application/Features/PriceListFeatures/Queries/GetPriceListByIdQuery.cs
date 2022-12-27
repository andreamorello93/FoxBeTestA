using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.PriceListFeatures.Queries
{
    public class GetPriceListByIdQuery : IRequest<PriceListDto>
    {
        public int Id { get; set; }
        public class GetPriceListByIdQueryHandler : IRequestHandler<GetPriceListByIdQuery, PriceListDto>
        {
            private readonly IGenericProcessor<PriceList, PriceListDto, int> _PriceListProcessor;

            public GetPriceListByIdQueryHandler(IGenericProcessor<PriceList, PriceListDto, int> PriceListProcessor)
            {
                _PriceListProcessor = PriceListProcessor;
            }
            public async Task<PriceListDto> Handle(GetPriceListByIdQuery query, CancellationToken cancellationToken)
            {
                return await _PriceListProcessor.ExecuteGetById(query.Id);
            }
        }
    }
}
