﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using MediatR;

namespace FoxBeTestA.Application.Features.RoomTypeFeatures.Commands
{
    public class DeleteRoomTypeByIdCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public class DeleteRoomTypeByIdCommandHandler : IRequestHandler<DeleteRoomTypeByIdCommand, bool>
        {
            private readonly IGenericProcessor<RoomType, RoomType, int> _roomTypeProcessor;

            public DeleteRoomTypeByIdCommandHandler(IGenericProcessor<RoomType, RoomType, int> roomTypeProcessor)
            {
                _roomTypeProcessor = roomTypeProcessor;
            }
            public async Task<bool> Handle(DeleteRoomTypeByIdCommand command, CancellationToken cancellationToken)
            {
                return await _roomTypeProcessor.ExecuteDelete(command.Id);
            }
        }
    }
}
