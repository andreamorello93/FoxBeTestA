using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public ICollection<RoomType> RoomTypes { get; set; }
    }
}
