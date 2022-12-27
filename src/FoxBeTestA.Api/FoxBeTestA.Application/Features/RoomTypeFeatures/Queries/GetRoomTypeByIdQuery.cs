using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.Application.Processors;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Queries
{
    public class GetRoomTypeByIdQuery : IRequest<RoomTypeDto>
    {
        public int Id { get; set; }
        public class GetRoomTypeByIdQueryHandler : IRequestHandler<GetRoomTypeByIdQuery, RoomTypeDto>
        {
            private readonly IRoomTypeProcessor _RoomTypeProcessor;

            public GetRoomTypeByIdQueryHandler(IRoomTypeProcessor RoomTypeProcessor)
            {
                _RoomTypeProcessor = RoomTypeProcessor;
            }
            public async Task<RoomTypeDto> Handle(GetRoomTypeByIdQuery query, CancellationToken cancellationToken)
            {
                return await _RoomTypeProcessor.ExecuteGetByIdToDto(query.Id);
            }
        }
    }
}
