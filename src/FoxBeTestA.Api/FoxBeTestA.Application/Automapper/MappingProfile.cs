using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Features.AccomodationFeatures.Commands;
using FoxBeTestA.Application.Features.RoomTypeFeatures.Commands;
using FoxBeTestA.DAL.Models;

namespace FoxBeTestA.Application.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Accomodation, AccomodationDto>();
            CreateMap<RoomType, RoomTypeDto>();

            CreateMap<UpdateAccomodationCommand, Accomodation>();
            CreateMap<CreateAccomodationCommand, Accomodation>();
            CreateMap<CreateRoomTypeCommand, RoomType>();
            CreateMap<UpdateRoomTypeCommand, RoomType>();
        }
    }
}
