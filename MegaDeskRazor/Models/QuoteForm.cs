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

        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z ]*$"), Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        //[Required, Display(Name = "Quote Date"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:d MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Required, Display(Name = "Quote Date"), DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        [Required, Range(24, 96)]
        public int Width { get; set; }

        [Required, Range(12, 48)]
        public int Depth { get; set; }

        public int Area { get; set; } //todo: hide this on add quote form

        [Required, Range(0, 7)]
        public int Drawers { get; set; }

        [Required]
        public DesktopMaterial Material { get; set; }

        [Required, Display(Name = "Rush Option")]
        public string RushOption { get; set; }

        public string Total { get; set; } //todo: hide this on add quote form
    }
}
