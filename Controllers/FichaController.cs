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
    public class FichaController : Controller
    {
        private readonly ContextoDb _context;

        public FichaController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Ficha
        public async Task<IActionResult> Index()
        {
            var contextoDb = _context.TBFICHA.Include(t => t.FichaEscOrigemUnidade);
            return View(await contextoDb.ToListAsync());
        }

        // GET: Ficha/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBFICHA == null)
            {
                return NotFound();
            }

            var tBFicha = await _context.TBFICHA
                .Include(t => t.FichaEscOrigemUnidade)
                .FirstOrDefaultAsync(m => m.FichaId == id);
            if (tBFicha == null)
            {
                return NotFound();
            }

            return View(tBFicha);
        }

        // GET: Ficha/Create
        public IActionResult Create()
        {
            ViewData["FichaEscOrigemUnidadeId"] = new SelectList(_context.TBUNIDADES, "UnidadeId", "UnidadeDesc");
            ViewData["AluId"] = new SelectList(_context.TBALUNO, "AluId", "AluNom");
            ViewData["CatId"] = new SelectList(_context.TBCATEGORIA, "CatId", "CatDesc");
            return View();
        }

        // POST: Ficha/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FichaId,FichaCatId,FichaStsId,FichaAtualUnidadeId,FichaNova,AluId,FichaEscOrigemUnidadeId,FichaDtaIni,FichaDtaFim,FichaIncPor,FichaIncEm,FichaAltPor,FichaAltEm")] TBFicha tBFicha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBFicha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FichaEscOrigemUnidadeId"] = new SelectList(_context.TBUNIDADES, "UnidadeId", "UnidadeDesc", tBFicha.FichaEscOrigemUnidadeId);
            return View(tBFicha);
        }

        // GET: Ficha/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBFICHA == null)
            {
                return NotFound();
            }

            var tBFicha = await _context.TBFICHA.FindAsync(id);
            if (tBFicha == null)
            {
                return NotFound();
            }
            ViewData["FichaEscOrigemUnidadeId"] = new SelectList(_context.TBUNIDADES, "UnidadeId", "UnidadeId", tBFicha.FichaEscOrigemUnidadeId);
            return View(tBFicha);
        }

        // POST: Ficha/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FichaId,FichaCatId,FichaStsId,FichaAtualUnidadeId,FichaNova,AluId,FichaEscOrigemUnidadeId,FichaDtaIni,FichaDtaFim,FichaIncPor,FichaIncEm,FichaAltPor,FichaAltEm")] TBFicha tBFicha)
        {
            if (id != tBFicha.FichaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBFicha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBFichaExists(tBFicha.FichaId))
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
            ViewData["FichaEscOrigemUnidadeId"] = new SelectList(_context.TBUNIDADES, "UnidadeId", "UnidadeId", tBFicha.FichaEscOrigemUnidadeId);
            return View(tBFicha);
        }

        // GET: Ficha/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBFICHA == null)
            {
                return NotFound();
            }

            var tBFicha = await _context.TBFICHA
                .Include(t => t.FichaEscOrigemUnidade)
                .FirstOrDefaultAsync(m => m.FichaId == id);
            if (tBFicha == null)
            {
                return NotFound();
            }

            return View(tBFicha);
        }

        // POST: Ficha/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBFICHA == null)
            {
                return Problem("Entity set 'ContextoDb.TBFICHA'  is null.");
            }
            var tBFicha = await _context.TBFICHA.FindAsync(id);
            if (tBFicha != null)
            {
                _context.TBFICHA.Remove(tBFicha);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBFichaExists(int id)
        {
          return (_context.TBFICHA?.Any(e => e.FichaId == id)).GetValueOrDefault();
        }
    }
}
