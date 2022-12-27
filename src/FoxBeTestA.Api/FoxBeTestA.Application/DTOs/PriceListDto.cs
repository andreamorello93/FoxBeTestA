using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoxBeTestA.DAL.Models
{
    public class PriceListDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RoomTypeId { get; set; }
        public decimal Price { get; set; }
    }
}
