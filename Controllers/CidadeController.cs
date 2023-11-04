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
    public class CidadeController : Controller
    {
        private readonly ContextoDb _context;

        public CidadeController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Cidade
        public async Task<IActionResult> Index()
        {
            var contextoDb = _context.TBCIDADE.Include(t => t.CidEstado);
            return View(await contextoDb.ToListAsync());
        }

        // GET: Cidade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBCIDADE == null)
            {
                return NotFound();
            }

            var tBCidade = await _context.TBCIDADE
                .Include(t => t.CidEstado)
                .FirstOrDefaultAsync(m => m.CidId == id);
            if (tBCidade == null)
            {
                return NotFound();
            }

            return View(tBCidade);
        }

        // GET: Cidade/Create
        public IActionResult Create()
        {
            ViewData["EstId"] = new SelectList(_context.TBESTADO, "EstId", "EstId");
            return View();
        }

        // POST: Cidade/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CidId,CidNom,CidEstNom,CidCodIbge,CidTipo,CidIdDistrito,CidNomDistrito,CidIncPor,CidIncEm,CidAltPor,CidAltEm,EstId")] TBCidade tBCidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBCidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstId"] = new SelectList(_context.TBESTADO, "EstId", "EstId", tBCidade.EstId);
            return View(tBCidade);
        }

        // GET: Cidade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBCIDADE == null)
            {
                return NotFound();
            }

            var tBCidade = await _context.TBCIDADE.FindAsync(id);
            if (tBCidade == null)
            {
                return NotFound();
            }
            ViewData["EstId"] = new SelectList(_context.TBESTADO, "EstId", "EstId", tBCidade.EstId);
            return View(tBCidade);
        }

        // POST: Cidade/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CidId,CidNom,CidEstNom,CidCodIbge,CidTipo,CidIdDistrito,CidNomDistrito,CidIncPor,CidIncEm,CidAltPor,CidAltEm,EstId")] TBCidade tBCidade)
        {
            if (id != tBCidade.CidId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBCidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBCidadeExists(tBCidade.CidId))
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
            ViewData["EstId"] = new SelectList(_context.TBESTADO, "EstId", "EstId", tBCidade.EstId);
            return View(tBCidade);
        }

        // GET: Cidade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBCIDADE == null)
            {
                return NotFound();
            }

            var tBCidade = await _context.TBCIDADE
                .Include(t => t.CidEstado)
                .FirstOrDefaultAsync(m => m.CidId == id);
            if (tBCidade == null)
            {
                return NotFound();
            }

            return View(tBCidade);
        }

        // POST: Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBCIDADE == null)
            {
                return Problem("Entity set 'ContextoDb.TBCIDADE'  is null.");
            }
            var tBCidade = await _context.TBCIDADE.FindAsync(id);
            if (tBCidade != null)
            {
                _context.TBCIDADE.Remove(tBCidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBCidadeExists(int id)
        {
          return (_context.TBCIDADE?.Any(e => e.CidId == id)).GetValueOrDefault();
        }
    }
}
