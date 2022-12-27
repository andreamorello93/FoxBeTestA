using AutoMapper;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.Application.Processors;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Commands
{
    public class CreateRoomTypeCommand : IRequest<int>
    {
        public string Description { get; set; }
        public int AccomodationId { get; set; }
        public int ExtraPercentageFromBasePrice { get; set; }

        public class CreateRoomTypeCommandHandler : IRequestHandler<CreateRoomTypeCommand, int>
        {
            private readonly IRoomTypeProcessor _roomTypeProcessor;
            private readonly IMapper _mapper;

            public CreateRoomTypeCommandHandler(IRoomTypeProcessor roomTypeProcessor, IMapper mapper)
            {
                _roomTypeProcessor = roomTypeProcessor;
                _mapper = mapper;
            }
            public async Task<int> Handle(CreateRoomTypeCommand command, CancellationToken cancellationToken)
            {
                var entity= await _roomTypeProcessor.ExecuteInsert(_mapper.Map<RoomType>(command));

                return entity.Id;
            }
        }
    }
}
