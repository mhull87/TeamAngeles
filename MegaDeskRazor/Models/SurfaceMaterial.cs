using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazor.Models
{
    public class SurfaceMaterial
    {
        public int ID { get; set; }
        [Required]
        public string Material { get; set; }
        public double Cost { get; set; }

        public string ImagePath { get; set; }
    }
}
