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
    public class FichaCategoriaOpcRespController : Controller
    {
        private readonly ContextoDb _context;

        public FichaCategoriaOpcRespController(ContextoDb context)
        {
            _context = context;
        }

        // GET: FichaCategoriaOpcResp
        public async Task<IActionResult> Index()
        {
              return _context.TBCATEGORIAOPCRESP != null ? 
                          View(await _context.TBCATEGORIAOPCRESP.ToListAsync()) :
                          Problem("Entity set 'ContextoDb.TBCATEGORIAOPCRESP'  is null.");
        }

        // GET: FichaCategoriaOpcResp/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBCATEGORIAOPCRESP == null)
            {
                return NotFound();
            }

            var tBFichaCategoriaOpcResp = await _context.TBCATEGORIAOPCRESP
                .FirstOrDefaultAsync(m => m.FichaCatOpcRespId == id);
            if (tBFichaCategoriaOpcResp == null)
            {
                return NotFound();
            }

            return View(tBFichaCategoriaOpcResp);
        }

        // GET: FichaCategoriaOpcResp/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FichaCategoriaOpcResp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FichaCatOpcRespId,CatOpcId,FichaId,FichaCatOpcResIncPor,FichaCatOpcIncEm,FichaCatOpcRespAltPor,FichaCatOpcRespAltEm")] TBFichaCategoriaOpcResp tBFichaCategoriaOpcResp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBFichaCategoriaOpcResp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBFichaCategoriaOpcResp);
        }

        // GET: FichaCategoriaOpcResp/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBCATEGORIAOPCRESP == null)
            {
                return NotFound();
            }

            var tBFichaCategoriaOpcResp = await _context.TBCATEGORIAOPCRESP.FindAsync(id);
            if (tBFichaCategoriaOpcResp == null)
            {
                return NotFound();
            }
            return View(tBFichaCategoriaOpcResp);
        }

        // POST: FichaCategoriaOpcResp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FichaCatOpcRespId,CatOpcId,FichaId,FichaCatOpcResIncPor,FichaCatOpcIncEm,FichaCatOpcRespAltPor,FichaCatOpcRespAltEm")] TBFichaCategoriaOpcResp tBFichaCategoriaOpcResp)
        {
            if (id != tBFichaCategoriaOpcResp.FichaCatOpcRespId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBFichaCategoriaOpcResp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBFichaCategoriaOpcRespExists(tBFichaCategoriaOpcResp.FichaCatOpcRespId))
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
            return View(tBFichaCategoriaOpcResp);
        }

        // GET: FichaCategoriaOpcResp/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBCATEGORIAOPCRESP == null)
            {
                return NotFound();
            }

            var tBFichaCategoriaOpcResp = await _context.TBCATEGORIAOPCRESP
                .FirstOrDefaultAsync(m => m.FichaCatOpcRespId == id);
            if (tBFichaCategoriaOpcResp == null)
            {
                return NotFound();
            }

            return View(tBFichaCategoriaOpcResp);
        }

        // POST: FichaCategoriaOpcResp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBCATEGORIAOPCRESP == null)
            {
                return Problem("Entity set 'ContextoDb.TBCATEGORIAOPCRESP'  is null.");
            }
            var tBFichaCategoriaOpcResp = await _context.TBCATEGORIAOPCRESP.FindAsync(id);
            if (tBFichaCategoriaOpcResp != null)
            {
                _context.TBCATEGORIAOPCRESP.Remove(tBFichaCategoriaOpcResp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBFichaCategoriaOpcRespExists(int id)
        {
          return (_context.TBCATEGORIAOPCRESP?.Any(e => e.FichaCatOpcRespId == id)).GetValueOrDefault();
        }
    }
}
