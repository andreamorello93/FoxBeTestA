using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Queries
{
    public class GetAllRoomTypesQuery : IRequest<IEnumerable<RoomType>>
    {
        public class GetAllRoomTypesQueryHandler : IRequestHandler<GetAllRoomTypesQuery, IEnumerable<RoomType>>
        {
            private readonly IGenericProcessor<RoomType, RoomType, int> _RoomTypeProcessor;

            public GetAllRoomTypesQueryHandler(IGenericProcessor<RoomType, RoomType, int> RoomTypeProcessor)
            {
                _RoomTypeProcessor = RoomTypeProcessor;
            }
            public async Task<IEnumerable<RoomType>> Handle(GetAllRoomTypesQuery query, CancellationToken cancellationToken)
            {
                return await _RoomTypeProcessor.ExecuteGetAll();
            }
        }
    }
}
