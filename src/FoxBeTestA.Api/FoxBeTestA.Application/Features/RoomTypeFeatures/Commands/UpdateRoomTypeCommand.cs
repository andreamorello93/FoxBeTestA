using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Commands
{
    public class UpdateRoomTypeCommand : IRequest<RoomType>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public class UpdateRoomTypeCommandHandler : IRequestHandler<UpdateRoomTypeCommand, RoomType>
        {
            private readonly IGenericProcessor<RoomType, RoomType, int> _roomTypeProcessor;
            private readonly IMapper _mapper;

            public UpdateRoomTypeCommandHandler(IGenericProcessor<RoomType, RoomType, int> roomTypeProcessor, IMapper mapper)
            {
                _roomTypeProcessor = roomTypeProcessor;
                _mapper = mapper;
            }
            public async Task<RoomType> Handle(UpdateRoomTypeCommand command, CancellationToken cancellationToken)
            {
                var RoomType = _mapper.Map<RoomType>(command);
                return await _roomTypeProcessor.ExecuteUpdate(RoomType.Id, RoomType);
            }
        }
    }
}
