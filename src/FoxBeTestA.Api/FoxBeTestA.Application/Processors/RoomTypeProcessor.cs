using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.Application.Repositories;
using FoxBeTestA.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FoxBeTestA.Application.Processors
{
    public interface IRoomTypeProcessor : IGenericProcessor<RoomType, RoomTypeDto, int>
    {
        Task<RoomType> GetRoomTypeWithAccomodationById(int id);
    }

    public class RoomTypeProcessor : GenericProcessor<RoomType, RoomTypeDto, int>, IRoomTypeProcessor
    {
        private readonly IRoomTypeRepository _roomTypeRepository;

        public RoomTypeProcessor(IRoomTypeRepository roomTypeRepository, IMapper mapper) : base(roomTypeRepository, mapper)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task<RoomType> GetRoomTypeWithAccomodationById(int id)
        {
            return await _roomTypeRepository.GetRoomTypeWithAccomodationById(id);
        }
    }
}
