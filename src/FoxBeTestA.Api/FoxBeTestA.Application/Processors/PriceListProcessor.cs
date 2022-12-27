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
    public class PriceListProcessor : GenericProcessor<PriceList, PriceListDto, int>
    {
        public PriceListProcessor(IGenericRepository<PriceList, int> priceListRepository, IMapper mapper) : base(priceListRepository, mapper)
        {
        }
    }
}
