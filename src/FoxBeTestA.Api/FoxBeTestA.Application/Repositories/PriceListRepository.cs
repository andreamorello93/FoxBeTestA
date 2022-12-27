using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Data;
using FoxBeTestA.DAL.Models;

namespace FoxBeTestA.Application.Repositories
{
    public class PriceListRepository : GenericRepository<PriceList, int>
    {
        public PriceListRepository(FoxBeTestAContext context) : base(context)
        {
                
        }
    }
}
