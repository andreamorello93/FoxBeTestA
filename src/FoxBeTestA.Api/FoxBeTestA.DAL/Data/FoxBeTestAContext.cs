using FoxBeTestA.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FoxBeTestA.DAL.Data
{
    public class FoxBeTestAContext : DbContext
    {
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<PriceList> PriceList { get; set; }

        public FoxBeTestAContext(DbContextOptions<FoxBeTestAContext> options)
            : base(options)
        {
        }
    }
}
