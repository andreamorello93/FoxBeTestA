using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Queries
{
    public class GetAllRoomTypesQuery : IRequest<IEnumerable<RoomTypeDto>>
    {
        public class GetAllRoomTypesQueryHandler : IRequestHandler<GetAllRoomTypesQuery, IEnumerable<RoomTypeDto>>
        {
            private readonly IGenericProcessor<RoomType, RoomTypeDto, int> _RoomTypeProcessor;

            public GetAllRoomTypesQueryHandler(IGenericProcessor<RoomType, RoomTypeDto, int> RoomTypeProcessor)
            {
                _RoomTypeProcessor = RoomTypeProcessor;
            }
            public async Task<IEnumerable<RoomTypeDto>> Handle(GetAllRoomTypesQuery query, CancellationToken cancellationToken)
            {
                return await _RoomTypeProcessor.ExecuteGetAll();
            }
        }
    }
}
