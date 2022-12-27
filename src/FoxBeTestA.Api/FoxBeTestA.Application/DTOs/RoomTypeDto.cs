using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoxBeTestA.DAL.Models
{
    public class RoomTypeDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AccomodationId { get; set; }
        public int ExtraPercentageFromBasePrice { get; set; }
    }
}
