using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoxBeTestA.DAL.Models
{
    [Index(nameof(Description), nameof(AccomodationId), IsUnique = true, Name = "IX_DescriptionAndAccomodationId_Unique")]
    public class RoomType
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; }
        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }

    }
}
