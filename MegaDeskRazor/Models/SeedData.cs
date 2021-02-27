using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MegaDeskRazor.Data;
using System;
using System.Linq;

namespace MegaDeskRazor.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskRazorContext>>()))
            {

                // Seed SurfaceMterial Table
                if(!context.SurfaceMaterial.Any())
                {
                    context.SurfaceMaterial.AddRange(
                        new SurfaceMaterial
                        {
                            Material = "Oak",
                            Cost = 200,
                            ImagePath = "~/Images/oak.jpg"
                        },

                        new SurfaceMaterial
                        {
                            Material = "Laminate",
                            Cost = 100,
                            ImagePath = "~/Images/laminate.jpg"
                        },

                        new SurfaceMaterial
                        {
                            Material = "Pine",
                            Cost = 50,
                            ImagePath = "~/Images/pine.jpg"
                        },

                        new SurfaceMaterial
                        {
                            Material = "Rosewood",
                            Cost = 300,
                            ImagePath = "~/Images/rosewood.jpg"
                        },

                        new SurfaceMaterial
                        {
                            Material = "Veneer",
                            Cost = 125,
                            ImagePath = "~/Images/veneer.jpg"
                        }
                    );
                }

                // Seeding Rusthtime table
                if (!context.RushTime.Any())
                {
                    context.RushTime.AddRange(
                        new RushTime
                        {
                            Days = "3"
                        },

                        new RushTime
                        {
                            Days = "5"
                        },

                        new RushTime
                        {
                            Days = "7"
                        },

                        new RushTime
                        {
                            Days = "14"
                        }

                    );
                }


                // Look for any quotes.
                if (!context.QuoteForm.Any())
                {
                    context.QuoteForm.AddRange(
                        new QuoteForm
                        {
                            CustomerName = "Harry McBride",
                            QuoteDate = DateTime.Parse("2021-2-23"),
                            Width = 24,
                            Depth = 12,
                            Drawers = 0,
                            Area = 288,
                            Material = DesktopMaterial.Laminate,
                            RushOption = "7",
                            Total = "$330.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Sierra Ramos",
                            QuoteDate = DateTime.Parse("2021-2-23"),
                            Width = 86,
                            Depth = 48,
                            Area = 4128,
                            Drawers = 7,
                            Material = DesktopMaterial.Rosewood,
                            RushOption = "3",
                            Total = "$4,058.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Lucinda Drage",
                            QuoteDate = DateTime.Parse("2021-2-23"),
                            Width = 50,
                            Depth = 36,
                            Area = 1800,
                            Drawers = 4,
                            Material = DesktopMaterial.Oak,
                            RushOption = "5",
                            Total = "$1,450.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Shelby Horn",
                            QuoteDate = DateTime.Parse("2021-2-23"),
                            Width = 34,
                            Depth = 34,
                            Area = 1156,
                            Drawers = 2,
                            Material = DesktopMaterial.Pine,
                            RushOption = "7",
                            Total = "$546.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Mary Lindval",
                            QuoteDate = DateTime.Parse("2021-2-24"),
                            Width = 86,
                            Depth = 33,
                            Area = 2838,
                            Drawers = 5,
                            Material = DesktopMaterial.Rosewood,
                            RushOption = "5",
                            Total = "$2,648.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Jim Brown",
                            QuoteDate = DateTime.Parse("2021-2-24"),
                            Width = 40,
                            Depth = 20,
                            Area = 800,
                            Drawers = 1,
                            Material = DesktopMaterial.Veneer,
                            RushOption = "5",
                            Total = "$415.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Jorge Ramos",
                            QuoteDate = DateTime.Parse("2021-2-25"),
                            Width = 75,
                            Depth = 40,
                            Area = 3000,
                            Drawers = 6,
                            Material = DesktopMaterial.Oak,
                            RushOption = "14",
                            Total = "$2,700.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Harry McBride",
                            QuoteDate = DateTime.Parse("2021-2-26"),
                            Width = 88,
                            Depth = 32,
                            Area = 2816,
                            Drawers = 7,
                            Material = DesktopMaterial.Veneer,
                            RushOption = "5",
                            Total = "$2,551.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Mary Brown",
                            QuoteDate = DateTime.Parse("2021-2-26"),
                            Width = 60,
                            Depth = 42,
                            Area = 2520,
                            Drawers = 4,
                            Material = DesktopMaterial.Pine,
                            RushOption = "3",
                            Total = "$2,050.00"
                        },

                        new QuoteForm
                        {
                            CustomerName = "Jim Brown",
                            QuoteDate = DateTime.Parse("2021-2-27"),
                            Width = 40,
                            Depth = 20,
                            Area = 800,
                            Drawers = 3,
                            Material = DesktopMaterial.Pine,
                            RushOption = "7",
                            Total = "$430.00"
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
