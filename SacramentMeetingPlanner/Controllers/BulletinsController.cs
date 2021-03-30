using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class BulletinsController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public BulletinsController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: Bulletins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bulletin.ToListAsync());
        }

        // GET: Bulletins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bulletin = await _context.Bulletin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bulletin == null)
            {
                return NotFound();
            }

            return View(bulletin);
        }

        // GET: Bulletins/Create
        public IActionResult Create()
        {
            //create default values for the prayers
            var vm = new Bulletin { Invocation = "By Invitation", Benediction = "By Invitation" };
            return View(vm);
        }

        // POST: Bulletins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BulletinDate,Conducting,OpeningSong,Invocation,SacramentSong,Speaker,IntermediateSong,ClosingSong,Benediction")] Bulletin bulletin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bulletin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bulletin);
        }

        // GET: Bulletins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bulletin = await _context.Bulletin.FindAsync(id);
            if (bulletin == null)
            {
                return NotFound();
            }
            return View(bulletin);
        }

        // POST: Bulletins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BulletinDate,Conducting,OpeningSong,Invocation,SacramentSong,Speaker,IntermediateSong,ClosingSong,Benediction")] Bulletin bulletin)
        {
            if (id != bulletin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bulletin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BulletinExists(bulletin.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bulletin);
        }

        // GET: Bulletins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bulletin = await _context.Bulletin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bulletin == null)
            {
                return NotFound();
            }

            return View(bulletin);
        }

        // POST: Bulletins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bulletin = await _context.Bulletin.FindAsync(id);
            _context.Bulletin.Remove(bulletin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BulletinExists(int id)
        {
            return _context.Bulletin.Any(e => e.Id == id);
        }
    }
}
