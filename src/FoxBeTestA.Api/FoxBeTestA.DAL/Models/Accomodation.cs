using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBeTestA.DAL.Models
{
    public class Accomodation
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<RoomType> RoomTypes { get; set; }
    }
}
