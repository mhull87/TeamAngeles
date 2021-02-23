using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazor.Models
{
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public class QuoteForm
    {        
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime QuoteDate { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Depth { get; set; }
        public int Area { get; set; }
        [Required]
        public int Drawers { get; set; }
        [Required]
        public DesktopMaterial Material { get; set; }
        public string RushOption { get; set; }
        public string Total { get; set; }

        public int CalculateArea()
        {
            Area = Width * Depth;
            return Area;
        }
    }
}
