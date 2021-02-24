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
                // Look for any movies.
                if (context.QuoteForm.Any())
                {
                    return;   // DB has been seeded
                }

                //context.SurfaceMaterial.AddRange(
                //    new SurfaceMaterial
                //    {
                //        Material = "Oak",
                //        Cost = 200,
                //        ImagePath = "~/Images/oak.jpg"
                //    },

                //    new SurfaceMaterial
                //    {
                //        Material = "Laminate",
                //        Cost = 100,
                //        ImagePath = "~/Images/laminate.jpg"
                //    },

                //    new SurfaceMaterial
                //    {
                //        Material = "Pine",
                //        Cost = 50,
                //        ImagePath = "~/Images/pine.jpg"
                //    },

                //    new SurfaceMaterial
                //    {
                //        Material = "Rosewood",
                //        Cost = 300,
                //        ImagePath = "~/Images/rosewood.jpg"
                //    },

                //    new SurfaceMaterial
                //    {
                //        Material = "Veneer",
                //        Cost = 125,
                //        ImagePath = "~/Images/veneer.jpg"
                //    }
                //);

                //context.RushTime.AddRange(
                //    new RushTime
                //    {
                //        Days = "3"
                //    },

                //    new RushTime
                //    {
                //        Days = "5"
                //    },

                //    new RushTime
                //    {
                //        Days = "7"
                //    }

                //);

                context.QuoteForm.AddRange(
                    new QuoteForm
                    {
                        CustomerName = "Harry McBride",
                        QuoteDate = DateTime.Parse("2-23-2021"),
                        Width = 24,
                        Depth = 12,
                        Drawers = 0,
                        Material = DesktopMaterial.Laminate,
                        RushOption = "7"
                    },

                    new QuoteForm
                    {
                        CustomerName = "Sierra Ramos",
                        QuoteDate = DateTime.Parse("2-23-2021"),
                        Width = 96,
                        Depth = 48,
                        Drawers = 7,
                        Material = DesktopMaterial.Rosewood,
                        RushOption = "3"
                    },

                    new QuoteForm
                    {
                        CustomerName = "Lucinda Drage",
                        QuoteDate = DateTime.Parse("2-23-2021"),
                        Width = 50,
                        Depth = 36,
                        Drawers = 4,
                        Material = DesktopMaterial.Oak,
                        RushOption = "5"
                    },

                    new QuoteForm
                    {
                        CustomerName = "Shelby Horn",
                        QuoteDate = DateTime.Parse("2-23-2021"),
                        Width = 34,
                        Depth = 34,
                        Drawers = 2,
                        Material = DesktopMaterial.Pine,
                        RushOption = "7"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
