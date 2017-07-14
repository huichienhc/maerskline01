using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace maerskline01.Models
{
    public class Ship
    {
        public int ShipID { get; set; }

        [Required]
        public String ShipName { get; set; }

        public int Capacity { get; set; }
    }
}