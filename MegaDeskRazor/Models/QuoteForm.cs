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
        [Display(Name = "Name")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Quote Date")]
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
        [Required]
        [Display(Name = "Rush Option")]
        public string RushOption { get; set; }
        public string Total { get; set; }
    }
}
