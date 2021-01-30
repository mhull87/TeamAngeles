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
        public double BasePrice {get; set;}
        public double InchPrice {get; set;}
        public double DrawerPrice { get; set; }
        public static Desk Desk { get; set; }
        public object ShippingBox { get; set; }
        public object Rush3 { get; private set; }
        public object Rush5 { get; private set; }
        public object Rush7 { get; private set; }

        static int  Area = Desk.Depth * Desk.Width;

        public DeskQuote()
        {
            // init default prices
            BasePrice = 200;
            InchPrice = 1;
            DrawerPrice = 50;
        }
        public int GetArea()
        {
            return Desk.Depth * Desk.Width;
        }
        public double AreaPrice()
        {
            return GetArea() * InchPrice;
        }
        public double DrawersPrice()
        {
            return Desk.Drawers * DrawerPrice;
        }
        public int ShippingSelection(int Area)
        {
            if (ShippingBox == Rush3)
            {
                if (Area < 1000)
                {
                    return 60;
                }
                else if (Area > 999 && Area < 2001)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }
            else if (ShippingBox == Rush5)
            {
                if (Area < 1000)
                {
                    return 40;
                }
                else if (Area > 999 && Area < 2001)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if (ShippingBox == Rush7)
            {
                if (Area < 1000)
                {
                    return 30;
                }
                else if (Area > 999 && Area < 2001)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            else
            {
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
                ShippingSelection(Area) + MaterialPrice();
            return total;
        }
    }
}
