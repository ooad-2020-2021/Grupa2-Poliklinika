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
    public class MedicinskiKartonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicinskiKartonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MedicinskiKartons
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedicinskiKarton.ToListAsync());
        }

        // GET: MedicinskiKartons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicinskiKarton = await _context.MedicinskiKarton
                .FirstOrDefaultAsync(m => m.brMedKartona == id);
            if (medicinskiKarton == null)
            {
                return NotFound();
            }

            return View(medicinskiKarton);
        }

        // GET: MedicinskiKartons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicinskiKartons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("brMedKartona,anamneza,medUsluga,dijagnoza,redniBrojPregleda,datum")] MedicinskiKarton medicinskiKarton)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicinskiKarton);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicinskiKarton);
        }

        // GET: MedicinskiKartons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicinskiKarton = await _context.MedicinskiKarton.FindAsync(id);
            if (medicinskiKarton == null)
            {
                return NotFound();
            }
            return View(medicinskiKarton);
        }

        // POST: MedicinskiKartons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("brMedKartona,anamneza,medUsluga,dijagnoza,redniBrojPregleda,datum")] MedicinskiKarton medicinskiKarton)
        {
            if (id != medicinskiKarton.brMedKartona)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicinskiKarton);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicinskiKartonExists(medicinskiKarton.brMedKartona))
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
            return View(medicinskiKarton);
        }

        // GET: MedicinskiKartons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicinskiKarton = await _context.MedicinskiKarton
                .FirstOrDefaultAsync(m => m.brMedKartona == id);
            if (medicinskiKarton == null)
            {
                return NotFound();
            }

            return View(medicinskiKarton);
        }

        // POST: MedicinskiKartons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicinskiKarton = await _context.MedicinskiKarton.FindAsync(id);
            _context.MedicinskiKarton.Remove(medicinskiKarton);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicinskiKartonExists(int id)
        {
            return _context.MedicinskiKarton.Any(e => e.brMedKartona == id);
        }
    }
}
