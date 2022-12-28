using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoxBeTestA.DAL.Models
{
    [Index(nameof(RoomTypeId), nameof(Date), IsUnique = true, Name = "IX_RoomTypeIdAndDate_Unique")]
    public class PriceList
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
