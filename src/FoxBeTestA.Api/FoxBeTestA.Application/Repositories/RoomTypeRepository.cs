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
    public class RoomTypeRepository : GenericRepository<RoomType, int>
    {
        public RoomTypeRepository(FoxBeTestAContext context) : base(context)
        {
                
        }
    }
}
