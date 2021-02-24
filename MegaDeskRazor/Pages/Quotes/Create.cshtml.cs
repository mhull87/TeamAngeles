using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRazor.Data;
using MegaDeskRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaDeskRazor.Pages.AddQuote
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskRazor.Data.MegaDeskRazorContext _context;
        public SelectList Materials { get; set; }
        public SelectList RushTime { get; set; }

        public CreateModel(MegaDeskRazor.Data.MegaDeskRazorContext context)
        {
            _context = context;

            // filling options for material and rushoptions
            IQueryable<string> materialQuery = from m in _context.SurfaceMaterial
                                               orderby m.Material
                                               select m.Material;
            Materials = new SelectList(materialQuery.Distinct().ToList());

            IQueryable<string> rushTimeQuery = from m in _context.RushTime
                                               orderby m.Days
                                               select m.Days;
            RushTime = new SelectList(rushTimeQuery.Distinct().ToList());


        }


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public QuoteForm QuoteForm { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.QuoteForm.Add(QuoteForm);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
