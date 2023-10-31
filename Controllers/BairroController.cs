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
    public class BairroController : Controller
    {
        private readonly ContextoDb _context;

        public BairroController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Bairro
        public async Task<IActionResult> Index()
        {
            var contextoDb = _context.TBAIRRO.Include(t => t.BairroCidade);
            return View(await contextoDb.ToListAsync());
        }

        // GET: Bairro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBAIRRO == null)
            {
                return NotFound();
            }

            var tBBairro = await _context.TBAIRRO
                .Include(t => t.BairroCidade)
                .FirstOrDefaultAsync(m => m.BairroId == id);
            if (tBBairro == null)
            {
                return NotFound();
            }

            return View(tBBairro);
        }

        // GET: Bairro/Create
        public IActionResult Create()
        {
            ViewData["CidadeId"] = new SelectList(_context.TBCIDADE, "CidId", "CidId");
            return View();
        }

        // POST: Bairro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BairroId,BairroNome,BairroIncPor,BairroAltPor,CidadeId,BairroIncEm,BairroAltEm")] TBBairro tBBairro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBBairro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CidadeId"] = new SelectList(_context.TBCIDADE, "CidId", "CidId", tBBairro.CidadeId);
            return View(tBBairro);
        }

        // GET: Bairro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBAIRRO == null)
            {
                return NotFound();
            }

            var tBBairro = await _context.TBAIRRO.FindAsync(id);
            if (tBBairro == null)
            {
                return NotFound();
            }
            ViewData["CidadeId"] = new SelectList(_context.TBCIDADE, "CidId", "CidId", tBBairro.CidadeId);
            return View(tBBairro);
        }

        // POST: Bairro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BairroId,BairroNome,BairroIncPor,BairroAltPor,CidadeId,BairroIncEm,BairroAltEm")] TBBairro tBBairro)
        {
            if (id != tBBairro.BairroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBBairro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBBairroExists(tBBairro.BairroId))
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
            ViewData["CidadeId"] = new SelectList(_context.TBCIDADE, "CidId", "CidId", tBBairro.CidadeId);
            return View(tBBairro);
        }

        // GET: Bairro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBAIRRO == null)
            {
                return NotFound();
            }

            var tBBairro = await _context.TBAIRRO
                .Include(t => t.BairroCidade)
                .FirstOrDefaultAsync(m => m.BairroId == id);
            if (tBBairro == null)
            {
                return NotFound();
            }

            return View(tBBairro);
        }

        // POST: Bairro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBAIRRO == null)
            {
                return Problem("Entity set 'ContextoDb.TBAIRRO'  is null.");
            }
            var tBBairro = await _context.TBAIRRO.FindAsync(id);
            if (tBBairro != null)
            {
                _context.TBAIRRO.Remove(tBBairro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBBairroExists(int id)
        {
          return (_context.TBAIRRO?.Any(e => e.BairroId == id)).GetValueOrDefault();
        }
    }
}
