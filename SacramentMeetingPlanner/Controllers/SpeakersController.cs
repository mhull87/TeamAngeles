﻿using System;
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
    public class SpeakersController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public SpeakersController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: Speakers
        public async Task<IActionResult> Index()
        {
            var sacramentMeetingPlannerContext = _context.Speaker/*.Include(s => s.Bulletin)*/;
            return View(await sacramentMeetingPlannerContext.ToListAsync());
        }

        // GET: Speakers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speaker
                /*.Include(s => s.Bulletin)*/
                .FirstOrDefaultAsync(m => m.SpeakerID == id);
            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // GET: Speakers/Create
        public IActionResult Create(int bulletinID)
        {
            /*ViewData["BulletinID"] = new SelectList(_context.Bulletin, "Id", "ClosingSong");*/
            return View(new Speaker { BulletinID = bulletinID});
        }

        // POST: Speakers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpeakerID,BulletinID,FirstName,LastName,Topic,CheckSpeaker,BeforeHymn")] Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speaker);
                await _context.SaveChangesAsync();
                if (speaker.CheckSpeaker)
                {
                    return RedirectToAction("Create", "Speakers", new { BulletinID = speaker.BulletinID });
                }
                return RedirectToAction("Index", "Bulletins");
            }
            /*ViewData["BulletinID"] = new SelectList(_context.Bulletin, "Id", "ClosingSong", speaker.BulletinID);*/
            return View(speaker);
        }

        // GET: Speakers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speaker.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }
            ViewData["BulletinID"] = new SelectList(_context.Bulletin, "Id", "ClosingSong", speaker.BulletinID);
            return View(speaker);
        }

        // POST: Speakers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpeakerID,BulletinID,FirstName,LastName,Topic")] Speaker speaker)
        {
            if (id != speaker.SpeakerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speaker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeakerExists(speaker.SpeakerID))
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
            ViewData["BulletinID"] = new SelectList(_context.Bulletin, "Id", "ClosingSong", speaker.BulletinID);
            return View(speaker);
        }

        // GET: Speakers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speaker
                /*.Include(s => s.Bulletin)*/
                .FirstOrDefaultAsync(m => m.SpeakerID == id);
            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // POST: Speakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speaker = await _context.Speaker.FindAsync(id);
            _context.Speaker.Remove(speaker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpeakerExists(int id)
        {
            return _context.Speaker.Any(e => e.SpeakerID == id);
        }
    }
}
