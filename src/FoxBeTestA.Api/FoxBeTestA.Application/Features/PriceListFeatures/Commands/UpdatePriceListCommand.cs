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

namespace FoxBeTestA.Application.Features.PriceListFeatures.Commands
{
    public class UpdatePriceListCommand : IRequest<PriceListDto>
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public class UpdatePriceListCommandHandler : IRequestHandler<UpdatePriceListCommand, PriceListDto>
        {
            private readonly IGenericProcessor<PriceList, PriceListDto, int> _PriceListProcessor;
            private readonly IMapper _mapper;

            public UpdatePriceListCommandHandler(IGenericProcessor<PriceList, PriceListDto, int> PriceListProcessor, IMapper mapper)
            {
                _PriceListProcessor = PriceListProcessor;
                _mapper = mapper;
            }
            public async Task<PriceListDto> Handle(UpdatePriceListCommand command, CancellationToken cancellationToken)
            {
                var PriceList = _mapper.Map<PriceList>(command);
                return await _PriceListProcessor.ExecuteUpdateToDto(PriceList.Id, PriceList);
            }
        }
    }
}
