using AutoMapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;

namespace FoxBeTestA.Application.Processors
{
    public interface IPriceListProcessor : IGenericProcessor<PriceList, PriceListDto, int>
    {
        Task<PriceListDto> ExecuteInsertToDto(decimal? Price, PriceList entity);
    }

    public class PriceListProcessor : GenericProcessor<PriceList, PriceListDto, int>, IPriceListProcessor
    {
        private readonly IRoomTypeProcessor _roomtypeProcessor;

        public PriceListProcessor(IGenericRepository<PriceList, int> priceListRepository, IRoomTypeProcessor roomtypeProcessor, IMapper mapper) : base(priceListRepository, mapper)
        {
            _roomtypeProcessor = roomtypeProcessor;
        }

        public async Task<PriceListDto> ExecuteInsertToDto(decimal? Price, PriceList entity)
        {
            if (Price == null)
                await CalculatePriceByBaseRoomPrice(entity);

            return await base.ExecuteInsertToDto(entity);
        }

        private async Task CalculatePriceByBaseRoomPrice(PriceList entity)
        {
            var roomType = await _roomtypeProcessor.GetRoomTypeWithAccomodationById(entity.RoomTypeId);

            entity.Price = ((roomType.Accomodation.BaseRoomPrice / 100) * roomType.ExtraPercentageFromBasePrice) +
                           roomType.Accomodation.BaseRoomPrice;
        }
    }
}
