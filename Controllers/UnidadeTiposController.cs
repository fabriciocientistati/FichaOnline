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
    public class UnidadeTiposController : Controller
    {
        private readonly ContextoDb _context;

        public UnidadeTiposController(ContextoDb context)
        {
            _context = context;
        }

        // GET: UnidadeTipos
        public async Task<IActionResult> Index()
        {
              return _context.TBUNIDADETIPOS != null ? 
                          View(await _context.TBUNIDADETIPOS.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBUNIDADETIPOS'  is null.");
        }

        // GET: UnidadeTipos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBUNIDADETIPOS == null)
            {
                return NotFound();
            }

            var tBUnidadeTipos = await _context.TBUNIDADETIPOS
                .FirstOrDefaultAsync(m => m.UnidadeTpoId == id);
            if (tBUnidadeTipos == null)
            {
                return NotFound();
            }

            return View(tBUnidadeTipos);
        }

        // GET: UnidadeTipos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UnidadeTipos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnidadeTpoId,UnidadeTpoDsc,UnidadeSgl,UnidadeTipo,UnidadeTpoIncPor,UnidadeTpoIncEm,UnidadeTpoAltPor,UnidadeTpoAltEm")] TBUnidadeTipos tBUnidadeTipos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBUnidadeTipos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBUnidadeTipos);
        }

        // GET: UnidadeTipos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBUNIDADETIPOS == null)
            {
                return NotFound();
            }

            var tBUnidadeTipos = await _context.TBUNIDADETIPOS.FindAsync(id);
            if (tBUnidadeTipos == null)
            {
                return NotFound();
            }
            return View(tBUnidadeTipos);
        }

        // POST: UnidadeTipos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UnidadeTpoId,UnidadeTpoDsc,UnidadeSgl,UnidadeTipo,UnidadeTpoIncPor,UnidadeTpoIncEm,UnidadeTpoAltPor,UnidadeTpoAltEm")] TBUnidadeTipos tBUnidadeTipos)
        {
            if (id != tBUnidadeTipos.UnidadeTpoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBUnidadeTipos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBUnidadeTiposExists(tBUnidadeTipos.UnidadeTpoId))
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
            return View(tBUnidadeTipos);
        }

        // GET: UnidadeTipos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBUNIDADETIPOS == null)
            {
                return NotFound();
            }

            var tBUnidadeTipos = await _context.TBUNIDADETIPOS
                .FirstOrDefaultAsync(m => m.UnidadeTpoId == id);
            if (tBUnidadeTipos == null)
            {
                return NotFound();
            }

            return View(tBUnidadeTipos);
        }

        // POST: UnidadeTipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBUNIDADETIPOS == null)
            {
                return Problem("Entity set 'ContextoDb.TBUNIDADETIPOS'  is null.");
            }
            var tBUnidadeTipos = await _context.TBUNIDADETIPOS.FindAsync(id);
            if (tBUnidadeTipos != null)
            {
                _context.TBUNIDADETIPOS.Remove(tBUnidadeTipos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBUnidadeTiposExists(int id)
        {
          return (_context.TBUNIDADETIPOS?.Any(e => e.UnidadeTpoId == id)).GetValueOrDefault();
        }
    }
}
