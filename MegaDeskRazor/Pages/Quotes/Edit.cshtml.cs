﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazor.Data;
using MegaDeskRazor.Models;

namespace MegaDeskRazor.Pages.AddQuote
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskRazor.Data.MegaDeskRazorContext _context;

        public SelectList Materials { get; set; }
        public SelectList RushTime { get; set; }

        public EditModel(MegaDeskRazor.Data.MegaDeskRazorContext context)
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

        [BindProperty]
        public QuoteForm QuoteForm { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuoteForm = await _context.QuoteForm.FirstOrDefaultAsync(m => m.ID == id);

            if (QuoteForm == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(new QuoteForm(QuoteForm.ID, QuoteForm.CustomerName, QuoteForm.QuoteDate, QuoteForm.Width, QuoteForm.Depth, QuoteForm.Drawers, QuoteForm.Material, QuoteForm.RushOption)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteFormExists(QuoteForm.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QuoteFormExists(int id)
        {
            return _context.QuoteForm.Any(e => e.ID == id);
        }
    }
}
