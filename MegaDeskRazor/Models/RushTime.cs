using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazor.Models
{
    public class RushTime
    {
        public int ID { get; set; }
        [Required]
        public string Days { get; set; }
    }
}
