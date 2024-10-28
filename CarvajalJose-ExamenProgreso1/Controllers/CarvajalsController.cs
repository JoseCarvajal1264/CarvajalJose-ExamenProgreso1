using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarvajalJose_ExamenProgreso1.Data;
using CarvajalJose_ExamenProgreso1.Models;

namespace CarvajalJose_ExamenProgreso1.Controllers
{
    public class CarvajalsController : Controller
    {
        private readonly CarvajalJose_ExamenProgreso1Context _context;

        public CarvajalsController(CarvajalJose_ExamenProgreso1Context context)
        {
            _context = context;
        }

        // GET: Carvajals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carvajal.ToListAsync());
        }

        // GET: Carvajals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carvajal = await _context.Carvajal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carvajal == null)
            {
                return NotFound();
            }

            return View(carvajal);
        }

        // GET: Carvajals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carvajals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Altura,Trabajando,Fecha")] Carvajal carvajal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carvajal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carvajal);
        }

        // GET: Carvajals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carvajal = await _context.Carvajal.FindAsync(id);
            if (carvajal == null)
            {
                return NotFound();
            }
            return View(carvajal);
        }

        // POST: Carvajals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Altura,Trabajando,Fecha")] Carvajal carvajal)
        {
            if (id != carvajal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carvajal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarvajalExists(carvajal.Id))
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
            return View(carvajal);
        }

        // GET: Carvajals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carvajal = await _context.Carvajal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carvajal == null)
            {
                return NotFound();
            }

            return View(carvajal);
        }

        // POST: Carvajals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carvajal = await _context.Carvajal.FindAsync(id);
            if (carvajal != null)
            {
                _context.Carvajal.Remove(carvajal);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarvajalExists(int id)
        {
            return _context.Carvajal.Any(e => e.Id == id);
        }
    }
}
