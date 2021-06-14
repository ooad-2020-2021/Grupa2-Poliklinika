using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PoliklinikaApp.Data;
using PoliklinikaApp.Models;

namespace PoliklinikaApp.Controllers
{
    public class PregledsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PregledsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pregleds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pregled.ToListAsync());
        }

        // GET: Pregleds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregled = await _context.Pregled
                .FirstOrDefaultAsync(m => m.id_pregleda == id);
            if (pregled == null)
            {
                return NotFound();
            }

            return View(pregled);
        }

        // GET: Pregleds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pregleds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_pregleda,datum")] Pregled pregled)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pregled);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pregled);
        }

        // GET: Pregleds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregled = await _context.Pregled.FindAsync(id);
            if (pregled == null)
            {
                return NotFound();
            }
            return View(pregled);
        }

        // POST: Pregleds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_pregleda,datum")] Pregled pregled)
        {
            if (id != pregled.id_pregleda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pregled);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PregledExists(pregled.id_pregleda))
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
            return View(pregled);
        }

        // GET: Pregleds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregled = await _context.Pregled
                .FirstOrDefaultAsync(m => m.id_pregleda == id);
            if (pregled == null)
            {
                return NotFound();
            }

            return View(pregled);
        }

        // POST: Pregleds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pregled = await _context.Pregled.FindAsync(id);
            _context.Pregled.Remove(pregled);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PregledExists(int id)
        {
            return _context.Pregled.Any(e => e.id_pregleda == id);
        }
    }
}
