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
    public class RasporedZaZakazivanjesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RasporedZaZakazivanjesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RasporedZaZakazivanjes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RasporedZaZakazivanje.ToListAsync());
        }

        // GET: RasporedZaZakazivanjes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasporedZaZakazivanje = await _context.RasporedZaZakazivanje
                .FirstOrDefaultAsync(m => m.id_rasporeda == id);
            if (rasporedZaZakazivanje == null)
            {
                return NotFound();
            }

            return View(rasporedZaZakazivanje);
        }

        // GET: RasporedZaZakazivanjes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RasporedZaZakazivanjes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_rasporeda,vrijeme")] RasporedZaZakazivanje rasporedZaZakazivanje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rasporedZaZakazivanje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rasporedZaZakazivanje);
        }

        // GET: RasporedZaZakazivanjes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasporedZaZakazivanje = await _context.RasporedZaZakazivanje.FindAsync(id);
            if (rasporedZaZakazivanje == null)
            {
                return NotFound();
            }
            return View(rasporedZaZakazivanje);
        }

        // POST: RasporedZaZakazivanjes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_rasporeda,vrijeme")] RasporedZaZakazivanje rasporedZaZakazivanje)
        {
            if (id != rasporedZaZakazivanje.id_rasporeda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rasporedZaZakazivanje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RasporedZaZakazivanjeExists(rasporedZaZakazivanje.id_rasporeda))
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
            return View(rasporedZaZakazivanje);
        }

        // GET: RasporedZaZakazivanjes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasporedZaZakazivanje = await _context.RasporedZaZakazivanje
                .FirstOrDefaultAsync(m => m.id_rasporeda == id);
            if (rasporedZaZakazivanje == null)
            {
                return NotFound();
            }

            return View(rasporedZaZakazivanje);
        }

        // POST: RasporedZaZakazivanjes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rasporedZaZakazivanje = await _context.RasporedZaZakazivanje.FindAsync(id);
            _context.RasporedZaZakazivanje.Remove(rasporedZaZakazivanje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RasporedZaZakazivanjeExists(int id)
        {
            return _context.RasporedZaZakazivanje.Any(e => e.id_rasporeda == id);
        }
    }
}
