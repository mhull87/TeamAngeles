﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskRazor.Models
{
    //this class will be deleted, it is for reference only
    public class DeskQuote
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string QuoteDate { get; set; }

        public Desk desk;

        public string RushOption { get; set; }
        public double TotalCost { get; set; }

        public const int BASEPRICE = 200;
        public const int INCHPRICE = 1;
        public const int DRAWERPRICE = 50;

        public DeskQuote()
        {
            CustomerName = string.Empty;
            QuoteDate = string.Empty;
            RushOption = string.Empty;
            desk = new Desk();
        }

        public double AreaPrice()
        {
            desk.CalculateArea();
            if (desk.area > 1000)
            {
                return BASEPRICE + (desk.area - 1000) * INCHPRICE;
            }
            else
            {
                return BASEPRICE;
            }
        }

        public double DrawersPrice()
        {
            return desk.Drawers * DRAWERPRICE;
        }

        public double GetRushOrder()
        {
            try
            {
                var lines = File.ReadAllLines("rushOrderPrices.txt", Encoding.UTF8);
                double[,] rushCosts = new double[3, 3]
                {
                    {Convert.ToDouble(lines[0]), Convert.ToDouble(lines[1]), Convert.ToDouble(lines[2])},
                    {Convert.ToDouble(lines[3]), Convert.ToDouble(lines[4]), Convert.ToDouble(lines[5])},
                    {Convert.ToDouble(lines[6]), Convert.ToDouble(lines[7]), Convert.ToDouble(lines[8])},
                };

                double rushCost = 0;

                switch (RushOption)
                {
                    case "3 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = rushCosts[0, 0];
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = rushCosts[0, 2];
                        }
                        else
                        {
                            rushCost = rushCosts[0, 1];
                        }
                        break;
                    case "5 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = rushCosts[1, 0];
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = rushCosts[1, 2];
                        }
                        else
                        {
                            rushCost = rushCosts[1, 1];
                        }
                        break;
                    case "7 Days":
                        if (desk.area < 1000)
                        {
                            rushCost = rushCosts[2, 0];
                        }
                        else if (desk.area > 2000)
                        {
                            rushCost = rushCosts[2, 2];
                        }
                        else
                        {
                            rushCost = rushCosts[2, 1];
                        }
                        break;
                }
                return rushCost;
            }
            catch (Exception)
            {
                throw;
            }
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
            TotalCost = AreaPrice() + DrawersPrice() + GetRushOrder() + MaterialPrice();
            return TotalCost;
        }
    }

    public struct Quotes
    {
        public string CustomerName { get; set; }
        public string QuoteDate { get; set; }
        public string RushOption { get; set; }
        public double TotalCost { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public string Material { get; set; }
        public int Area { get; set; }
    }
}