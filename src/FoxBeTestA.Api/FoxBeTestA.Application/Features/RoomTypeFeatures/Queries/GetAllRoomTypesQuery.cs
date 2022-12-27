using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.Application.Processors;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Queries
{
    public class GetAllRoomTypesQuery : IRequest<IEnumerable<RoomTypeDto>>
    {
        public class GetAllRoomTypesQueryHandler : IRequestHandler<GetAllRoomTypesQuery, IEnumerable<RoomTypeDto>>
        {
            private readonly IRoomTypeProcessor _RoomTypeProcessor;

            public GetAllRoomTypesQueryHandler(IRoomTypeProcessor RoomTypeProcessor)
            {
                _RoomTypeProcessor = RoomTypeProcessor;
            }
            public async Task<IEnumerable<RoomTypeDto>> Handle(GetAllRoomTypesQuery query, CancellationToken cancellationToken)
            {
                return await _RoomTypeProcessor.ExecuteGetAllToDto();
            }
        }
    }
}
