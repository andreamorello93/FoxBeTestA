using AutoMapper;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Commands
{
    public class CreateRoomTypeCommand : IRequest<int>
    {
        public string Description { get; set; }
        public int AccomodationId { get; set; }

        public class CreateRoomTypeCommandHandler : IRequestHandler<CreateRoomTypeCommand, int>
        {
            private readonly IGenericProcessor<RoomType, RoomTypeDto, int> _roomTypeProcessor;
            private readonly IMapper _mapper;

            public CreateRoomTypeCommandHandler(IGenericProcessor<RoomType, RoomTypeDto, int> roomTypeProcessor, IMapper mapper)
            {
                _roomTypeProcessor = roomTypeProcessor;
                _mapper = mapper;
            }
            public async Task<int> Handle(CreateRoomTypeCommand command, CancellationToken cancellationToken)
            {
                var roomType = _mapper.Map<RoomType>(command);
                var entity= await _roomTypeProcessor.ExecuteInsert(roomType);

                return entity.Id;
            }
        }
    }
}
