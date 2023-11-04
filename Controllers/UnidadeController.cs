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
    public class UnidadeController : Controller
    {
        private readonly ContextoDb _context;

        public UnidadeController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Unidade
        public async Task<IActionResult> Index()
        {
            var contextoDb = _context.TBUNIDADES.Include(t => t.Polo).Include(t => t.TiposUnidade);
            return View(await contextoDb.ToListAsync());
        }

        // GET: Unidade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBUNIDADES == null)
            {
                return NotFound();
            }

            var tBUnidades = await _context.TBUNIDADES
                .Include(t => t.Polo)
                .Include(t => t.TiposUnidade)
                .FirstOrDefaultAsync(m => m.UnidadeId == id);
            if (tBUnidades == null)
            {
                return NotFound();
            }

            return View(tBUnidades);
        }

        // GET: Unidade/Create
        public IActionResult Create()
        {
            ViewData["PoloId"] = new SelectList(_context.TBPOLO, "PoloId", "PoloNome");
            ViewData["UnidadesTpoId"] = new SelectList(_context.TBUNIDADETIPOS, "UnidadeTpoId", "UnidadeTpoDsc");
            return View();
        }

        // POST: Unidade/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnidadeCod,UnidadeDesc,UnidadeStatus,UnidadeEmail,UnidadeDDD,UnidadeFone,UnidadeCEP,UnidadeEndNmr,UnidadeEndLog,UnidadeEndComp,UnidadeIncPor,UnidadeIncEm,UnidadeAltPor,UnidadeAltEm,UnidadesTpoId,PoloId")] TBUnidades tBUnidades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBUnidades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PoloId"] = new SelectList(_context.TBPOLO, "PoloId", "PoloNome", tBUnidades.PoloId);
            ViewData["UnidadesTpoId"] = new SelectList(_context.TBUNIDADETIPOS, "UnidadeTpoId", "UnidadeTpoDsc", tBUnidades.UnidadesTpoId);
            return View(tBUnidades);
        }

        // GET: Unidade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBUNIDADES == null)
            {
                return NotFound();
            }

            var tBUnidades = await _context.TBUNIDADES.FindAsync(id);
            if (tBUnidades == null)
            {
                return NotFound();
            }
            ViewData["PoloId"] = new SelectList(_context.TBPOLO, "PoloId", "PoloId", tBUnidades.PoloId);
            ViewData["UnidadesTpoId"] = new SelectList(_context.TBUNIDADETIPOS, "UnidadeTpoId", "UnidadeTpoId", tBUnidades.UnidadesTpoId);
            return View(tBUnidades);
        }

        // POST: Unidade/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UnidadeId,UnidadeCod,UnidadeDesc,UnidadeStatus,UnidadeEmail,UnidadeDDD,UnidadeFone,UnidadeCEP,UnidadeEndNmr,UnidadeEndLog,UnidadeEndComp,UnidadeIncPor,UnidadeIncEm,UnidadeAltPor,UnidadeAltEm,UnidadesTpoId,PoloId")] TBUnidades tBUnidades)
        {
            if (id != tBUnidades.UnidadeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBUnidades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBUnidadesExists(tBUnidades.UnidadeId))
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
            ViewData["PoloId"] = new SelectList(_context.TBPOLO, "PoloId", "PoloId", tBUnidades.PoloId);
            ViewData["UnidadesTpoId"] = new SelectList(_context.TBUNIDADETIPOS, "UnidadeTpoId", "UnidadeTpoId", tBUnidades.UnidadesTpoId);
            return View(tBUnidades);
        }

        // GET: Unidade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBUNIDADES == null)
            {
                return NotFound();
            }

            var tBUnidades = await _context.TBUNIDADES
                .Include(t => t.Polo)
                .Include(t => t.TiposUnidade)
                .FirstOrDefaultAsync(m => m.UnidadeId == id);
            if (tBUnidades == null)
            {
                return NotFound();
            }

            return View(tBUnidades);
        }

        // POST: Unidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBUNIDADES == null)
            {
                return Problem("Entity set 'ContextoDb.TBUNIDADES'  is null.");
            }
            var tBUnidades = await _context.TBUNIDADES.FindAsync(id);
            if (tBUnidades != null)
            {
                _context.TBUNIDADES.Remove(tBUnidades);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBUnidadesExists(int id)
        {
          return (_context.TBUNIDADES?.Any(e => e.UnidadeId == id)).GetValueOrDefault();
        }
    }
}
