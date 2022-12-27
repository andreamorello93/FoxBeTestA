using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.Application.Processors;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Commands
{
    public class UpdateRoomTypeCommand : IRequest<RoomTypeDto>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AccomodationId { get; set; }
        public int ExtraPercentageFromBasePrice { get; set; }

        public class UpdateRoomTypeCommandHandler : IRequestHandler<UpdateRoomTypeCommand, RoomTypeDto>
        {
            private readonly IRoomTypeProcessor _roomTypeProcessor;
            private readonly IMapper _mapper;

            public UpdateRoomTypeCommandHandler(IRoomTypeProcessor roomTypeProcessor, IMapper mapper)
            {
                _roomTypeProcessor = roomTypeProcessor;
                _mapper = mapper;
            }
            public async Task<RoomTypeDto> Handle(UpdateRoomTypeCommand command, CancellationToken cancellationToken)
            {
                var RoomType = _mapper.Map<RoomType>(command);
                return await _roomTypeProcessor.ExecuteUpdateToDto(RoomType.Id, RoomType);
            }
        }
    }
}
