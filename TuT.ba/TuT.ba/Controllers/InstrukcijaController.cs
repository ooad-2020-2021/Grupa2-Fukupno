using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TuT.ba.Data;
using TuT.ba.Models;

namespace TuT.ba.Controllers
{
    public class InstrukcijaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstrukcijaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Instrukcija
        public async Task<IActionResult> Index()
        {
            return View(await _context.Instrukcija.ToListAsync());
        }

        // GET: Instrukcija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrukcija = await _context.Instrukcija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (instrukcija == null)
            {
                return NotFound();
            }

            return View(instrukcija);
        }

        // GET: Instrukcija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instrukcija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DatumOdrzavanja,Trajanje,Cijena,Popust")] Instrukcija instrukcija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instrukcija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instrukcija);
        }

        // GET: Instrukcija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrukcija = await _context.Instrukcija.FindAsync(id);
            if (instrukcija == null)
            {
                return NotFound();
            }
            return View(instrukcija);
        }

        // POST: Instrukcija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DatumOdrzavanja,Trajanje,Cijena,Popust")] Instrukcija instrukcija)
        {
            if (id != instrukcija.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instrukcija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstrukcijaExists(instrukcija.ID))
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
            return View(instrukcija);
        }

        // GET: Instrukcija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrukcija = await _context.Instrukcija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (instrukcija == null)
            {
                return NotFound();
            }

            return View(instrukcija);
        }

        // POST: Instrukcija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instrukcija = await _context.Instrukcija.FindAsync(id);
            _context.Instrukcija.Remove(instrukcija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstrukcijaExists(int id)
        {
            return _context.Instrukcija.Any(e => e.ID == id);
        }
    }
}
