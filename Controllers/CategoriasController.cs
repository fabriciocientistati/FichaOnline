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
    public class CategoriasController : Controller
    {
        private readonly ContextoDb _context;

        public CategoriasController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
              return _context.TBCATEGORIA != null ? 
                          View(await _context.TBCATEGORIA.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBCATEGORIA'  is null.");
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBCATEGORIA == null)
            {
                return NotFound();
            }

            var tBCategoria = await _context.TBCATEGORIA
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (tBCategoria == null)
            {
                return NotFound();
            }

            return View(tBCategoria);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,CatDesc,CatSts,CatIncPor,CatIncEm,CatAltPor,CatAltEm")] TBCategoria tBCategoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBCategoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBCategoria);
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBCATEGORIA == null)
            {
                return NotFound();
            }

            var tBCategoria = await _context.TBCATEGORIA.FindAsync(id);
            if (tBCategoria == null)
            {
                return NotFound();
            }
            return View(tBCategoria);
        }

        // POST: Categorias/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,CatDesc,CatSts,CatIncPor,CatIncEm,CatAltPor,CatAltEm")] TBCategoria tBCategoria)
        {
            if (id != tBCategoria.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBCategoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBCategoriaExists(tBCategoria.CatId))
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
            return View(tBCategoria);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBCATEGORIA == null)
            {
                return NotFound();
            }

            var tBCategoria = await _context.TBCATEGORIA
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (tBCategoria == null)
            {
                return NotFound();
            }

            return View(tBCategoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBCATEGORIA == null)
            {
                return Problem("Entity set 'ContextoDb.TBCATEGORIA'  is null.");
            }
            var tBCategoria = await _context.TBCATEGORIA.FindAsync(id);
            if (tBCategoria != null)
            {
                _context.TBCATEGORIA.Remove(tBCategoria);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBCategoriaExists(int id)
        {
          return (_context.TBCATEGORIA?.Any(e => e.CatId == id)).GetValueOrDefault();
        }
    }
}
