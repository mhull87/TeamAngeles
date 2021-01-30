using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskAngeles
{
    public class DeskQuote
    {
        public string customerName;
        public string quoteDate;
        public Desk desk;
        public string rushOption;
        public double totalCost;

        public const int BASEPRICE = 200;
        public const int INCHPRICE = 1;
        public const int DRAWERPRICE = 50;

        public DeskQuote()
        {
            customerName = string.Empty;
            quoteDate = string.Empty;
            rushOption = string.Empty;
        }

        public double AreaPrice()
        {
            desk.CalculateArea();
            if (desk.area > 1000)
            {
                return BASEPRICE + (desk.area - 1000) * INCHPRICE;
            } else
            {
                return BASEPRICE;
            }            
        }

        public double DrawersPrice()
        {
            return desk.drawers * DRAWERPRICE;
        }

        public double RushSelection()
        {
            double rushCost = 0;
            try
            {
                switch (rushOption)
                {
                    case "3 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = 60;
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = 80;
                        }
                        else
                        {
                            rushCost = 70;
                        }
                        break;
                    case "5 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = 40;
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = 60;
                        }
                        else
                        {
                            rushCost = 50;
                        }
                        break;
                    case "7 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = 30;
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = 40;
                        }
                        else
                        {
                            rushCost = 35;
                        }
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return rushCost;
        }

        public double MaterialPrice()
        {
            // select price by the surface desktop material
            switch (desk.Material)
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
            totalCost = AreaPrice() + DrawersPrice() + RushSelection() + MaterialPrice();
            return totalCost;
        }
    }
}