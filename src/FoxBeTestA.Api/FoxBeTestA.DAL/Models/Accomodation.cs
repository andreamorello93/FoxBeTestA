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
    public class Accomodation
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BaseRoomPrice { get; set; }
        public ICollection<RoomType> RoomTypes { get; set; }
    }
}
