using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Queries
{
    public class GetRoomTypeByIdQuery : IRequest<RoomTypeDto>
    {
        public int Id { get; set; }
        public class GetRoomTypeByIdQueryHandler : IRequestHandler<GetRoomTypeByIdQuery, RoomTypeDto>
        {
            private readonly IGenericProcessor<RoomType, RoomTypeDto, int> _RoomTypeProcessor;

            public GetRoomTypeByIdQueryHandler(IGenericProcessor<RoomType, RoomTypeDto, int> RoomTypeProcessor)
            {
                _RoomTypeProcessor = RoomTypeProcessor;
            }
            public async Task<RoomTypeDto> Handle(GetRoomTypeByIdQuery query, CancellationToken cancellationToken)
            {
                return await _RoomTypeProcessor.ExecuteGetById(query.Id);
            }
        }
    }
}
