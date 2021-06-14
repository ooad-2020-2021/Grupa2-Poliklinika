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
    public class NalazsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NalazsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nalazs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nalaz.ToListAsync());
        }

        // GET: Nalazs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nalaz = await _context.Nalaz
                .FirstOrDefaultAsync(m => m.id_nalaza == id);
            if (nalaz == null)
            {
                return NotFound();
            }

            return View(nalaz);
        }

        // GET: Nalazs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nalazs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_nalaza,misljenje,statusPacijenta")] Nalaz nalaz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nalaz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nalaz);
        }

        // GET: Nalazs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nalaz = await _context.Nalaz.FindAsync(id);
            if (nalaz == null)
            {
                return NotFound();
            }
            return View(nalaz);
        }

        // POST: Nalazs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_nalaza,misljenje,statusPacijenta")] Nalaz nalaz)
        {
            if (id != nalaz.id_nalaza)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nalaz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NalazExists(nalaz.id_nalaza))
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
            return View(nalaz);
        }

        // GET: Nalazs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nalaz = await _context.Nalaz
                .FirstOrDefaultAsync(m => m.id_nalaza == id);
            if (nalaz == null)
            {
                return NotFound();
            }

            return View(nalaz);
        }

        // POST: Nalazs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nalaz = await _context.Nalaz.FindAsync(id);
            _context.Nalaz.Remove(nalaz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NalazExists(int id)
        {
            return _context.Nalaz.Any(e => e.id_nalaza == id);
        }
    }
}
