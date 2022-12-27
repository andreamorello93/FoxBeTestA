﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBeTestA.DAL.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }

    }
}
