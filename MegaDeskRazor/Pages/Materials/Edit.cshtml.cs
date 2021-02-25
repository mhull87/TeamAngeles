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

namespace MegaDeskRazor.Pages.Materials
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskRazor.Data.MegaDeskRazorContext _context;

        public EditModel(MegaDeskRazor.Data.MegaDeskRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SurfaceMaterial SurfaceMaterial { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SurfaceMaterial = await _context.SurfaceMaterial.FirstOrDefaultAsync(m => m.ID == id);

            if (SurfaceMaterial == null)
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

            _context.Attach(SurfaceMaterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurfaceMaterialExists(SurfaceMaterial.ID))
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

        private bool SurfaceMaterialExists(int id)
        {
            return _context.SurfaceMaterial.Any(e => e.ID == id);
        }
    }
}