using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace maerskline01.Models
{
    public class Container
    {
        public int ContainerID { get; set; }

        [Required]
        public String ContainerName { get; set; }

        public int ContainerWeight { get; set; }
    }
}