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
    public class RasporedPregledasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RasporedPregledasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RasporedPregledas
        public async Task<IActionResult> Index()
        {
            return View(await _context.RasporedPregleda.ToListAsync());
        }

        // GET: RasporedPregledas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasporedPregleda = await _context.RasporedPregleda
                .FirstOrDefaultAsync(m => m.id_rasporeda == id);
            if (rasporedPregleda == null)
            {
                return NotFound();
            }

            return View(rasporedPregleda);
        }

        // GET: RasporedPregledas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RasporedPregledas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("zakazanTermin,slobodanTermin,otkazanTermin,id_rasporeda,vrijeme")] RasporedPregleda rasporedPregleda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rasporedPregleda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rasporedPregleda);
        }

        // GET: RasporedPregledas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasporedPregleda = await _context.RasporedPregleda.FindAsync(id);
            if (rasporedPregleda == null)
            {
                return NotFound();
            }
            return View(rasporedPregleda);
        }

        // POST: RasporedPregledas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("zakazanTermin,slobodanTermin,otkazanTermin,id_rasporeda,vrijeme")] RasporedPregleda rasporedPregleda)
        {
            if (id != rasporedPregleda.id_rasporeda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rasporedPregleda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RasporedPregledaExists(rasporedPregleda.id_rasporeda))
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
            return View(rasporedPregleda);
        }

        // GET: RasporedPregledas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasporedPregleda = await _context.RasporedPregleda
                .FirstOrDefaultAsync(m => m.id_rasporeda == id);
            if (rasporedPregleda == null)
            {
                return NotFound();
            }

            return View(rasporedPregleda);
        }

        // POST: RasporedPregledas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rasporedPregleda = await _context.RasporedPregleda.FindAsync(id);
            _context.RasporedPregleda.Remove(rasporedPregleda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RasporedPregledaExists(int id)
        {
            return _context.RasporedPregleda.Any(e => e.id_rasporeda == id);
        }
    }
}
