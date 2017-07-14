using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace maerskline01.Models
{
    public class Shipyard
    {
        public int ShipyardID { get; set; }

        [Required]
        public String ShipyardName { get; set; }

        public String Location { get; set; }


    }
}