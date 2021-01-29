using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskAngeles
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public string Rush { get; set; }
        public double BasePrice {get; set;}
        public double InchPrice {get; set;}
        public double DrawerPrice { get; set; }

        public Desk Desk { get; set; }

        public DeskQuote()
        {
            // init default prices
            BasePrice = 200;
            InchPrice = 1;
            DrawerPrice = 50;
        }
        public double AreaPrice()
        {
            return Desk.GetArea() * InchPrice;
        }

        public double DrawersPrice()
        {
            return Desk.Drawers * DrawerPrice;
        }

        public double RushPrice(int size)
        {
            // Select price by rush time and size.
            switch (Rush)
            {
                case "7 days":
                    if (size<1000)
                    {
                        return 30;
                    }
                    else if (size <=2000)
                    {
                        return 35;
                    }
                    else
                    {
                        return 40;
                    }
                    break;
                case "5 days":
                    if (size < 1000)
                    {
                        return 40;
                    }
                    else if (size <= 2000)
                    {
                        return 50;
                    }
                    else
                    {
                        return 60;
                    }
                case "3 days":
                    if (size < 1000)
                    {
                        return 60;
                    }
                    else if (size <= 2000)
                    {
                        return 70;
                    }
                    else
                    {
                        return 80;
                    }
                default:
                    return 0;
            }
        }

        public double MaterialPrice()
        {
            // select price by the surface desktop material
            switch (Desk.Material)
            {
                case DesktopMaterial.Oak:
                    return 200;
                case DesktopMaterial.Laminate:
                    return 100;
                case DesktopMaterial.Pine:
                    return 50;
                case DesktopMaterial.Rosewood:
                    return 300;
                case DesktopMaterial.Veneer:
                    return 125;
                default:
                    return 0;
            }
        }

        public double TotalQuote()
        {
            double total = BasePrice + AreaPrice() + DrawersPrice() + 
                RushPrice(Desk.GetArea()) + MaterialPrice();
            return total;
        }
    }

}
