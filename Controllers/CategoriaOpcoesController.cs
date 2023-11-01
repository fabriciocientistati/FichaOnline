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
    public class CategoriaOpcoesController : Controller
    {
        private readonly ContextoDb _context;

        public CategoriaOpcoesController(ContextoDb context)
        {
            _context = context;
        }

        // GET: CategoriaOpcoes
        public async Task<IActionResult> Index()
        {
              return _context.TBCATEGORIAOPCOES != null ? 
                          View(await _context.TBCATEGORIAOPCOES.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBCATEGORIAOPCOES'  is null.");
        }

        // GET: CategoriaOpcoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBCATEGORIAOPCOES == null)
            {
                return NotFound();
            }

            var tBCategoriaOpcoes = await _context.TBCATEGORIAOPCOES
                .FirstOrDefaultAsync(m => m.CatOpcId == id);
            if (tBCategoriaOpcoes == null)
            {
                return NotFound();
            }

            return View(tBCategoriaOpcoes);
        }

        // GET: CategoriaOpcoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaOpcoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatOpcId,CatId,CatOpcDesc,CatOpcIncPor,CatOpcIncEm,CatOpcAltPor,CatOpcAltEm")] TBCategoriaOpcoes tBCategoriaOpcoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBCategoriaOpcoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBCategoriaOpcoes);
        }

        // GET: CategoriaOpcoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBCATEGORIAOPCOES == null)
            {
                return NotFound();
            }

            var tBCategoriaOpcoes = await _context.TBCATEGORIAOPCOES.FindAsync(id);
            if (tBCategoriaOpcoes == null)
            {
                return NotFound();
            }
            return View(tBCategoriaOpcoes);
        }

        // POST: CategoriaOpcoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatOpcId,CatId,CatOpcDesc,CatOpcIncPor,CatOpcIncEm,CatOpcAltPor,CatOpcAltEm")] TBCategoriaOpcoes tBCategoriaOpcoes)
        {
            if (id != tBCategoriaOpcoes.CatOpcId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBCategoriaOpcoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBCategoriaOpcoesExists(tBCategoriaOpcoes.CatOpcId))
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
            return View(tBCategoriaOpcoes);
        }

        // GET: CategoriaOpcoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBCATEGORIAOPCOES == null)
            {
                return NotFound();
            }

            var tBCategoriaOpcoes = await _context.TBCATEGORIAOPCOES
                .FirstOrDefaultAsync(m => m.CatOpcId == id);
            if (tBCategoriaOpcoes == null)
            {
                return NotFound();
            }

            return View(tBCategoriaOpcoes);
        }

        // POST: CategoriaOpcoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBCATEGORIAOPCOES == null)
            {
                return Problem("Entity set 'ContextoDb.TBCATEGORIAOPCOES'  is null.");
            }
            var tBCategoriaOpcoes = await _context.TBCATEGORIAOPCOES.FindAsync(id);
            if (tBCategoriaOpcoes != null)
            {
                _context.TBCATEGORIAOPCOES.Remove(tBCategoriaOpcoes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBCategoriaOpcoesExists(int id)
        {
          return (_context.TBCATEGORIAOPCOES?.Any(e => e.CatOpcId == id)).GetValueOrDefault();
        }
    }
}
