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
    public class MaterijaliController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaterijaliController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Materijali
        public async Task<IActionResult> Index()
        {
            return View(await _context.Materijal.ToListAsync());
        }

        // GET: Materijali/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materijal = await _context.Materijal
                .FirstOrDefaultAsync(m => m.ID == id);
            if (materijal == null)
            {
                return NotFound();
            }

            return View(materijal);
        }

        // GET: Materijali/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Materijali/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,URL")] Materijal materijal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materijal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materijal);
        }

        // GET: Materijali/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materijal = await _context.Materijal.FindAsync(id);
            if (materijal == null)
            {
                return NotFound();
            }
            return View(materijal);
        }

        // POST: Materijali/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,URL")] Materijal materijal)
        {
            if (id != materijal.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materijal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterijalExists(materijal.ID))
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
            return View(materijal);
        }

        // GET: Materijali/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materijal = await _context.Materijal
                .FirstOrDefaultAsync(m => m.ID == id);
            if (materijal == null)
            {
                return NotFound();
            }

            return View(materijal);
        }

        // POST: Materijali/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materijal = await _context.Materijal.FindAsync(id);
            _context.Materijal.Remove(materijal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaterijalExists(int id)
        {
            return _context.Materijal.Any(e => e.ID == id);
        }
    }
}
