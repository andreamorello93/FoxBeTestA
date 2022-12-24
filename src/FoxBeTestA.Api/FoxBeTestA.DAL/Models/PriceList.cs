using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBeTestA.DAL.Models
{
    public class PriceList
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public decimal Price { get; set; }
    }
}
