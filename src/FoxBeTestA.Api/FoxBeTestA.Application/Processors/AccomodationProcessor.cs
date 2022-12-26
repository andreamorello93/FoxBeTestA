using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FoxBeTestA.Application.Processors
{
    public class AccomodationProcessor : GenericProcessor<Accomodation, AccomodationDto, int>
    {
       
        public AccomodationProcessor(IGenericRepository<Accomodation, int> accomodationRepository, IMapper mapper) : base(accomodationRepository, mapper)
        {
        }
    }
}
