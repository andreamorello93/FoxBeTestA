using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Data;
using FoxBeTestA.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FoxBeTestA.Application.Repositories
{
    public interface IRoomTypeRepository : IGenericRepository<RoomType, int>
    {
        Task<RoomType> GetRoomTypeWithAccomodationById(int id);
    }

    public class RoomTypeRepository : GenericRepository<RoomType, int>, IRoomTypeRepository
    {
        public RoomTypeRepository(FoxBeTestAContext context) : base(context)
        {
                
        }

        public async Task<RoomType> GetRoomTypeWithAccomodationById(int id)
        {
            return await _table.Include(a => a.Accomodation)
                .FirstAsync(rt => rt.Id == id);
        }
    }
}
