using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Queries
{
    public class GetRoomTypeByIdQuery : IRequest<RoomType>
    {
        public int Id { get; set; }
        public class GetRoomTypeByIdQueryHandler : IRequestHandler<GetRoomTypeByIdQuery, RoomType>
        {
            private readonly IGenericProcessor<RoomType, RoomType, int> _RoomTypeProcessor;

            public GetRoomTypeByIdQueryHandler(IGenericProcessor<RoomType, RoomType, int> RoomTypeProcessor)
            {
                _RoomTypeProcessor = RoomTypeProcessor;
            }
            public async Task<RoomType> Handle(GetRoomTypeByIdQuery query, CancellationToken cancellationToken)
            {
                return await _RoomTypeProcessor.ExecuteGetById(query.Id);
            }
        }
    }
}
