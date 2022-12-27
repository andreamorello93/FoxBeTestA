using AutoMapper;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.PriceListFeatures.Commands
{
    public class CreatePriceListCommand : IRequest<int>
    {
        public DateTime Date { get; set; }
        public int RoomTypeId { get; set; }
        public decimal? Price { get; set; }

        public class CreatePriceListCommandHandler : IRequestHandler<CreatePriceListCommand, int>
        {
            private readonly IGenericProcessor<PriceList, PriceListDto, int> _PriceListProcessor;
            private readonly IMapper _mapper;

            public CreatePriceListCommandHandler(IGenericProcessor<PriceList, PriceListDto, int> PriceListProcessor, IMapper mapper)
            {
                _PriceListProcessor = PriceListProcessor;
                _mapper = mapper;
            }
            public async Task<int> Handle(CreatePriceListCommand command, CancellationToken cancellationToken)
            {
                var entity= await _PriceListProcessor.ExecuteInsert(_mapper.Map<PriceList>(command));

                return entity.Id;
            }
        }
    }
}
