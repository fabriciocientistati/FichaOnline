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
    public class ProvidenciaController : Controller
    {
        private readonly ContextoDb _context;

        public ProvidenciaController(ContextoDb context)
        {
            _context = context;
        }

        // GET: Providencia
        public async Task<IActionResult> Index()
        {
            var contextoDb = _context.TBFICHAPROVIDENCIASRESP.Include(t => t.FichaProvFicha);
            return View(await contextoDb.ToListAsync());
        }

        // GET: Providencia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TBFICHAPROVIDENCIASRESP == null)
            {
                return NotFound();
            }

            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP
                .Include(t => t.FichaProvFicha)
                .FirstOrDefaultAsync(m => m.FichaProvRespId == id);
            if (tBFichaProvidenciasResp == null)
            {
                return NotFound();
            }

            return View(tBFichaProvidenciasResp);
        }

        // GET: Providencia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Providencia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FichaProvRespId,FichaId,FichaProvRespIncPor,FichaProvRespIncEm,FichaProvRespAltPor,FichaprovRespAltEm,FichaDtaComunicRespons,FichaMeioComunic,FichaPorQuemUsuariorId,FichaPraQuemUsuariorId,FichaProcedimentoUnidade,FichaRecebidoEm,FichaDataTramitacao,FichaDefineRetorno")] TBFichaProvidenciasResp tBFichaProvidenciasResp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBFichaProvidenciasResp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FichaId"] = new SelectList(_context.TBFICHA, "FichaId", "FichaId", tBFichaProvidenciasResp.FichaId);
            return View(tBFichaProvidenciasResp);
        }

        // GET: Providencia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TBFICHAPROVIDENCIASRESP == null)
            {
                return NotFound();
            }

            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP.FindAsync(id);
            if (tBFichaProvidenciasResp == null)
            {
                return NotFound();
            }
            ViewData["FichaId"] = new SelectList(_context.TBFICHA, "FichaId", "FichaId", tBFichaProvidenciasResp.FichaId);
            return View(tBFichaProvidenciasResp);
        }

        // POST: Providencia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FichaProvRespId,FichaId,FichaProvRespIncPor,FichaProvRespIncEm,FichaProvRespAltPor,FichaprovRespAltEm,FichaDtaComunicRespons,FichaMeioComunic,FichaPorQuemUsuariorId,FichaPraQuemUsuariorId,FichaProcedimentoUnidade,FichaRecebidoEm,FichaDataTramitacao,FichaDefineRetorno")] TBFichaProvidenciasResp tBFichaProvidenciasResp)
        {
            if (id != tBFichaProvidenciasResp.FichaProvRespId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBFichaProvidenciasResp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBFichaProvidenciasRespExists(tBFichaProvidenciasResp.FichaProvRespId))
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
            ViewData["FichaId"] = new SelectList(_context.TBFICHA, "FichaId", "FichaId", tBFichaProvidenciasResp.FichaId);
            return View(tBFichaProvidenciasResp);
        }

        // GET: Providencia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TBFICHAPROVIDENCIASRESP == null)
            {
                return NotFound();
            }

            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP
                .Include(t => t.FichaProvFicha)
                .FirstOrDefaultAsync(m => m.FichaProvRespId == id);
            if (tBFichaProvidenciasResp == null)
            {
                return NotFound();
            }

            return View(tBFichaProvidenciasResp);
        }

        // POST: Providencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TBFICHAPROVIDENCIASRESP == null)
            {
                return Problem("Entity set 'ContextoDb.TBFICHAPROVIDENCIASRESP'  is null.");
            }
            var tBFichaProvidenciasResp = await _context.TBFICHAPROVIDENCIASRESP.FindAsync(id);
            if (tBFichaProvidenciasResp != null)
            {
                _context.TBFICHAPROVIDENCIASRESP.Remove(tBFichaProvidenciasResp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBFichaProvidenciasRespExists(int id)
        {
          return (_context.TBFICHAPROVIDENCIASRESP?.Any(e => e.FichaProvRespId == id)).GetValueOrDefault();
        }
    }
}
