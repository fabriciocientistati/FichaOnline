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
    public class PoloController : Controller
    {
        private readonly ContextoDb _context;

        public PoloController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Polo
        public async Task<IActionResult> Index()
        {
              return _context.TBPOLO != null ? 
                          View(await _context.TBPOLO.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBPOLO'  is null.");
        }

        // GET: Polo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBPOLO == null)
            {
                return NotFound();
            }

            var tBPolo = await _context.TBPOLO
                .FirstOrDefaultAsync(m => m.PoloId == id);
            if (tBPolo == null)
            {
                return NotFound();
            }

            return View(tBPolo);
        }

        // GET: Polo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Polo/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PoloId,PoloNome,PoloStatus,PoloIncPor,PoloIncEm,PoloAltPor,PoloAltEm")] TBPolo tBPolo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBPolo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBPolo);
        }

        // GET: Polo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBPOLO == null)
            {
                return NotFound();
            }

            var tBPolo = await _context.TBPOLO.FindAsync(id);
            if (tBPolo == null)
            {
                return NotFound();
            }
            return View(tBPolo);
        }

        // POST: Polo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PoloId,PoloNome,PoloStatus,PoloIncPor,PoloIncEm,PoloAltPor,PoloAltEm")] TBPolo tBPolo)
        {
            if (id != tBPolo.PoloId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBPolo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBPoloExists(tBPolo.PoloId))
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
            return View(tBPolo);
        }

        // GET: Polo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBPOLO == null)
            {
                return NotFound();
            }

            var tBPolo = await _context.TBPOLO
                .FirstOrDefaultAsync(m => m.PoloId == id);
            if (tBPolo == null)
            {
                return NotFound();
            }

            return View(tBPolo);
        }

        // POST: Polo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBPOLO == null)
            {
                return Problem("Entity set 'ContextoDb.TBPOLO'  is null.");
            }
            var tBPolo = await _context.TBPOLO.FindAsync(id);
            if (tBPolo != null)
            {
                _context.TBPOLO.Remove(tBPolo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBPoloExists(int id)
        {
          return (_context.TBPOLO?.Any(e => e.PoloId == id)).GetValueOrDefault();
        }
    }
}
