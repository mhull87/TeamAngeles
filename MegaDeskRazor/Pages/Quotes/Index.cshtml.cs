using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazor.Data;
using MegaDeskRazor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskRazor.Pages.AddQuote
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazor.Data.MegaDeskRazorContext _context;

        public IndexModel(MegaDeskRazor.Data.MegaDeskRazorContext context)
        {
            _context = context;
        }

        public IList<QuoteForm> QuoteForm { get;set; }

        // for searching
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Materials { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SurfaceMaterial { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Sort { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> materialQuery = from m in _context.SurfaceMaterial
                                               orderby m.Material
                                               select m.Material;


            var quotes = from m in _context.QuoteForm
                             select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Console.WriteLine("Filtering");
                quotes = quotes.Where(s => s.CustomerName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SurfaceMaterial))
            {
                quotes = quotes.Where(x => x.Material == (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial),SurfaceMaterial));

            }

            if (!string.IsNullOrEmpty(Sort))
            {
                switch (Sort)
                {
                    case "Customer Name":
                        quotes = quotes.OrderBy(s => s.CustomerName);
                        break;
                    case "Quote Date":
                        quotes = quotes.OrderBy(s => s.QuoteDate);
                        break;
                    default:
                        break;
                }
            }

            //Scripture = await _context.Scripture.ToListAsync();
            Materials = new SelectList(await materialQuery.Distinct().ToListAsync());

            //QuoteForm = await _context.QuoteForm.ToListAsync();
            QuoteForm = await quotes.ToListAsync();
        }
    }
}
