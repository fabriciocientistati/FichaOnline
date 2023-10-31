using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaOnline.Data;
using FichaOnline.Models;

namespace FichaOnline.Controllers
{
    public class EstadoController : Controller
    {
        private readonly ContextoDb _context;

        public EstadoController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Estado
        public async Task<IActionResult> Index()
        {
              return _context.TBESTADO != null ? 
                          View(await _context.TBESTADO.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBESTADO'  is null.");
        }

        // GET: Estado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBESTADO == null)
            {
                return NotFound();
            }

            var tBEstado = await _context.TBESTADO
                .FirstOrDefaultAsync(m => m.EstId == id);
            if (tBEstado == null)
            {
                return NotFound();
            }

            return View(tBEstado);
        }

        // GET: Estado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstId,EstSgl,EstNom,EstIncPor,EstIncEm,EstAltPor,EstAltEm")] TBEstado tBEstado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBEstado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBEstado);
        }

        // GET: Estado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBESTADO == null)
            {
                return NotFound();
            }

            var tBEstado = await _context.TBESTADO.FindAsync(id);
            if (tBEstado == null)
            {
                return NotFound();
            }
            return View(tBEstado);
        }

        // POST: Estado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstId,EstSgl,EstNom,EstIncPor,EstIncEm,EstAltPor,EstAltEm")] TBEstado tBEstado)
        {
            if (id != tBEstado.EstId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBEstado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBEstadoExists(tBEstado.EstId))
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
            return View(tBEstado);
        }

        // GET: Estado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBESTADO == null)
            {
                return NotFound();
            }

            var tBEstado = await _context.TBESTADO
                .FirstOrDefaultAsync(m => m.EstId == id);
            if (tBEstado == null)
            {
                return NotFound();
            }

            return View(tBEstado);
        }

        // POST: Estado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBESTADO == null)
            {
                return Problem("Entity set 'ContextoDb.TBESTADO'  is null.");
            }
            var tBEstado = await _context.TBESTADO.FindAsync(id);
            if (tBEstado != null)
            {
                _context.TBESTADO.Remove(tBEstado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBEstadoExists(int id)
        {
          return (_context.TBESTADO?.Any(e => e.EstId == id)).GetValueOrDefault();
        }
    }
}
