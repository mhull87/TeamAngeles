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
        public QuoteForm()
        {
        }

        public QuoteForm(string customerName, DateTime date, int width, int depth, int drawers, DesktopMaterial material, string rush)
        {
            const int BASEPRICE = 200;
            const int INCHPRICE = 1;
            const int DRAWERPRICE = 50;

            double areaPrice;
            double drawerCost;
            double rushCost;
            double materialCost;

            CustomerName = customerName;
            QuoteDate = date;
            Width = width;
            Depth = depth;
            Drawers = drawers;
            Material = material;
            RushOption = rush;

            Area = width * depth;

            if (Area > 1000)
            {
                areaPrice = BASEPRICE + (Area - 1000) * INCHPRICE;
            }
            else
            {
                areaPrice = BASEPRICE;
            }

            drawerCost = Drawers * DRAWERPRICE;

            switch (RushOption)
            {
                case "3":
                    if (Area < 1000)
                    {
                        rushCost = 60;
                    }
                    else if (Area > 2000)
                    {
                        rushCost = 80;
                    }
                    else
                    {
                        rushCost = 70;
                    }
                    break;
                case "5":
                    if (Area < 1000)
                    {
                        rushCost = 40;
                    }
                    else if (Area > 2000)
                    {
                        rushCost = 60;
                    }
                    else
                    {
                        rushCost = 50;
                    }
                    break;
                case "7":
                    if (Area < 1000)
                    {
                        rushCost = 30;
                    }
                    else if (Area > 2000)
                    {
                        rushCost = 35;
                    }
                    else
                    {
                        rushCost = 40;
                    }
                    break;
                default:
                    rushCost = 0;
                    break;
            }

            switch (Material)
            {
                case DesktopMaterial.Oak:
                    materialCost = 200;
                    break;
                case DesktopMaterial.Laminate:
                    materialCost = 100;
                    break;
                case DesktopMaterial.Pine:
                    materialCost = 50;
                    break;
                case DesktopMaterial.Rosewood:
                    materialCost = 300;
                    break;
                case DesktopMaterial.Veneer:
                    materialCost = 125;
                    break;
                default:
                    materialCost = 0;
                    break;
            }

            Total = (areaPrice + drawerCost + rushCost + materialCost).ToString("C");
        }

        public QuoteForm(int id, string customerName, DateTime date, int width, int depth, int drawers, DesktopMaterial material, string rush)
        {
            ID = id; 
            
            const int BASEPRICE = 200;
            const int INCHPRICE = 1;
            const int DRAWERPRICE = 50;

            double areaPrice;
            double drawerCost;
            double rushCost;
            double materialCost;

            CustomerName = customerName;
            QuoteDate = date;
            Width = width;
            Depth = depth;
            Drawers = drawers;
            Material = material;
            RushOption = rush;

            Area = width * depth;

            if (Area > 1000)
            {
                areaPrice = BASEPRICE + (Area - 1000) * INCHPRICE;
            }
            else
            {
                areaPrice = BASEPRICE;
            }

            drawerCost = Drawers * DRAWERPRICE;

            switch (RushOption)
            {
                case "3":
                    if (Area < 1000)
                    {
                        rushCost = 60;
                    }
                    else if (Area > 2000)
                    {
                        rushCost = 80;
                    }
                    else
                    {
                        rushCost = 70;
                    }
                    break;
                case "5":
                    if (Area < 1000)
                    {
                        rushCost = 40;
                    }
                    else if (Area > 2000)
                    {
                        rushCost = 60;
                    }
                    else
                    {
                        rushCost = 50;
                    }
                    break;
                case "7":
                    if (Area < 1000)
                    {
                        rushCost = 30;
                    }
                    else if (Area > 2000)
                    {
                        rushCost = 35;
                    }
                    else
                    {
                        rushCost = 40;
                    }
                    break;
                default:
                    rushCost = 0;
                    break;
            }

            switch (Material)
            {
                case DesktopMaterial.Oak:
                    materialCost = 200;
                    break;
                case DesktopMaterial.Laminate:
                    materialCost = 100;
                    break;
                case DesktopMaterial.Pine:
                    materialCost = 50;
                    break;
                case DesktopMaterial.Rosewood:
                    materialCost = 300;
                    break;
                case DesktopMaterial.Veneer:
                    materialCost = 125;
                    break;
                default:
                    materialCost = 0;
                    break;
            }

            Total = (areaPrice + drawerCost + rushCost + materialCost).ToString("C");
        }

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
